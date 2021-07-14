using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Spammeri
{
    public partial class EmojiForm : Form
    {
        public BindingList<string> Emojis { get; } = new BindingList<string>
        {
            ":joy:",
            ":joy_cat:",
            ":zany_face:",
            ":stuck_out_tongue:",
            ":sunglasses:",
        };

        public EmojiForm()
        {
            InitializeComponent();

            emojisList.DataSource = Emojis;
        }

        private void EmojiForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void addBtn_Click(object sender, System.EventArgs e)
        {
            Emojis.Add(emojiTxt.Text.Trim());
        }

        private void removeBtn_Click(object sender, System.EventArgs e)
        {
            Emojis.RemoveAt(emojisList.SelectedIndex);
        }

        private void emojisList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            removeBtn.Enabled = emojisList.SelectedIndex != -1;
        }

        private void clearBtn_Click(object sender, System.EventArgs e)
        {
            Emojis.Clear();
        }

        private void loadBtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                using (var dialog = new OpenFileDialog())
                {
                    dialog.Title = "Open Text File";
                    dialog.Filter = "TEXT files|*.txt";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        foreach (var line in File.ReadAllLines(dialog.FileName))
                        {
                            Emojis.Add(line.Trim());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
