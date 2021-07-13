using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace Spammeri
{
    internal struct SpammerOptions
    {

        public string Text { get; set; }
        public int Delay { get; set; }
        public bool ApplyEmoji { get; set; }
        public bool ApplyMock { get; set; }
        public bool ApplyHex { get; set; }
        public bool ApplyEnter { get; set; }
        public bool ApplyCtrlv { get; set; }

        public string[] Emojis { get; set; }
    }

    internal static class Spammer
    {
        // Fields
        private static readonly WshShell _shell = new WshShell();
        private static long _spamsSent = 0;

        // Getters
        public static long SpamsSent => Interlocked.Read(ref _spamsSent);

        internal static Task<Exception> Start(SpammerOptions options, CancellationToken ct)
        {
            // Reset spams sent counter
            Interlocked.Exchange(ref _spamsSent, 0);

            return STAScheduler.Factory.StartNew(() =>
            {
                Exception ex = null;

                try
                {
                    var str = options.ApplyHex ? StringOperations.HexEscape(options.Text) : options.Text;
                    var list = StringOperations.GetWords(str);
                    var applyEmoji = options.ApplyEmoji && options.Emojis.Length != 0;

                    var waiter = new SpinWait();
                    var builder = new StringBuilder();
                    var random = new Random();
                    var watch = Stopwatch.StartNew();

                    do
                    {
                        foreach (var word in list)
                        {
                            if (applyEmoji)
                            {
                                builder.Append(options.Emojis[random.Next(options.Emojis.Length)]);
                            }

                            if (options.ApplyMock)
                            {
                                StringOperations.ApplyMocking(word, random);
                            }

                            builder.Append(word);
                            builder.Append(' ');
                        }


                        // Remove space from end
                        builder.Length -= 1;

                        // Apply enter
                        if (options.ApplyEnter)
                        {
                            builder.Append("\r\n");
                        }

                        if (options.ApplyCtrlv)
                        {
                            Clipboard.SetText(builder.ToString());
                            _shell.SendKeys("^{v}\r\n");
                        }
                        else
                        {
                            _shell.SendKeys(builder.ToString());
                        }

                        // Increment spam counter
                        Interlocked.Increment(ref _spamsSent);

                        // Spin until delay is passed or cancel is requested.
                        while ((watch.ElapsedMilliseconds < options.Delay) && !ct.IsCancellationRequested)
                        {
                            waiter.SpinOnce();
                        }

                        // Reset watch and builder
                        builder.Clear();
                        watch.Restart();
                    } while (!ct.IsCancellationRequested);
                }
                catch (Exception err)
                {
                    ex = err;
                }

                return ex;
            });
        }
    }
}
