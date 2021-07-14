using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spammeri.Spamming;

namespace Spammeri.Forms
{
    public partial class MainForm : Form
    {
        // DLL imports
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        // Const
        private const int StartID = 0;
        private const int StopID = 1;
        private const Keys DefaultStart = Keys.F7;
        private const Keys DefaultStop = Keys.F8;

        // Instance members
        private bool _enabled = false;
        private long _previousCount = 0;
        private CancellationTokenSource _cts = null;
        private Task<Exception> _spamTask = null;
        private readonly EmojiForm _emojiForm = new EmojiForm();

        public MainForm()
        {
            InitializeComponent();
            InitializeCombos();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                var id = (int)m.WParam;

                switch (id)
                {
                    case StartID:
                        Start();
                        break;
                    case StopID:
                        Stop();
                        break;
                }
            }

            base.WndProc(ref m);
        }

        private void InitializeCombos()
        {
            startHotkeyCombo.DataSource = Enum.GetValues(typeof(Keys));
            stopHotkeyCombo.DataSource = Enum.GetValues(typeof(Keys));

            SetDefaultHotkeys();
        }

        private void SetDefaultHotkeys()
        {
            SetHotkeys(DefaultStart, DefaultStop);
        }

        private void SetHotkeys(Keys start, Keys stop)
        {
            if (start == stop)
            {
                throw new Exception("Start hotkey can't be same as stop hotkey.");
            }

            startHotkeyCombo.SelectedItem = start;
            stopHotkeyCombo.SelectedItem = stop;

            // Unregister previous
            UnregisterHotKey(Handle, StartID);
            UnregisterHotKey(Handle, StopID);

            // Register new ones
            RegisterHotKey(Handle, StartID, 0, (int)start);
            RegisterHotKey(Handle, StopID, 0, (int)stop);
        }

        private void SetUIDisabled()
        {
            _emojiForm.Enabled = false;
            startHotkeyCombo.Enabled = false;
            stopHotkeyCombo.Enabled = false;       
            startBtn.Enabled = false;
            stopBtn.Enabled = true;
            applyEmoji.Enabled = false;
            applyMocking.Enabled = false;
            applyHex.Enabled = false;
            applyCtrlv.Enabled = false;
            applyEnter.Enabled = false;
            speedNumeric.Enabled = false;
            spamText.Enabled = false;
            showEmojiBtn.Enabled = false;
            spammingLbl.Text = "True";
            spammingLbl.ForeColor = Color.Green;
        }

        private void SetUIEnabled()
        {
            _emojiForm.Enabled = true;
            startHotkeyCombo.Enabled = true;
            stopHotkeyCombo.Enabled = true;
            startBtn.Enabled = true;
            stopBtn.Enabled = false;
            applyEmoji.Enabled = true;
            applyMocking.Enabled = true;
            applyHex.Enabled = true;
            applyCtrlv.Enabled = true;
            applyEnter.Enabled = true;
            speedNumeric.Enabled = true;
            spamText.Enabled = true;
            showEmojiBtn.Enabled = true;
            spammingLbl.Text = "False";
            spammingLbl.ForeColor = Color.Red;
        }

        private async void Start()
        {
            if (_enabled) return;
           
            // Check if spam-text is empty.
            if (spamText.TextLength == 0)
            {
                MessageBox.Show("SPAM text can not be empty.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Set enabled
            _enabled = true;

            // Set UI disabled
            SetUIDisabled();

            // Options for spamming
            var options = new SpammerOptions
            {
                Text = spamText.Text,
                Delay = Convert.ToInt32(speedNumeric.Value),
                ApplyEmoji = applyEmoji.Checked,
                ApplyMock = applyMocking.Checked,
                ApplyHex = applyHex.Checked,
                ApplyEnter = applyEnter.Checked,
                ApplyCtrlv = applyCtrlv.Checked,
                Emojis = _emojiForm.Emojis.ToArray(),
            };

            // Start spamming
            _cts = new CancellationTokenSource();
            _spamTask = Spammer.Start(options, _cts.Token);

            // Wait for task to complete, on ex warn
            var ex = await _spamTask;
            if (ex != null)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Stop();
            }
        }

        private async void Stop()
        {
            if (!_enabled) return;
            _enabled = false;

            // Cancel and wait for spam task to finish.
            using (_cts)
            {
                _cts.Cancel();
                await _spamTask;
            }

            // Set UI enabled.
            SetUIEnabled();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UnregisterHotKey(Handle, StartID);
            UnregisterHotKey(Handle, StopID);
            _cts?.Dispose();
        }

        private void startBtn_Click(object sender, MouseEventArgs e)
        {
            Start();
        }

        private void stopBtn_Click(object sender, MouseEventArgs e)
        {
            Stop();
        }

        private void statusTimer_Tick(object sender, EventArgs e)
        {
            var countNow = Spammer.SpamsSent;

            if (_previousCount != countNow)
            {
                sentLbl.Text = countNow.ToString();
                _previousCount = countNow;
            }
        }

        private void showEmojiBtn_Click(object sender, EventArgs e)
        {
            _emojiForm.Show();
            _emojiForm.BringToFront();
        }

        private void spamText_TextChanged(object sender, EventArgs e)
        {
            startBtn.Enabled = spamText.TextLength != 0;
        }
    }
}
