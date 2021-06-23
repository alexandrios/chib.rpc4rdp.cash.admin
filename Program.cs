using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace chib.rpc4rdp.cash.admin
{
    static class Program
    {
        public const string RDP_INSTANCE = "ADMIN";
        public const string RDP_DOMAIN = "chib.admin";
        public const string RDP_AGENT = "ADMIN_AGENT";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}