using System;
using System.Windows.Forms;
using Spammeri.Forms;
using Spammeri.Spamming;

namespace Spammeri
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            STAScheduler.Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new MainForm());
        }
    }
}
