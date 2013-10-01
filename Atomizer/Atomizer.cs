using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace Atomizer
{
    public static class Launcher
    {
        [STAThread]
        public static void Main()
        {
            ElementDatabase.InitializeLists();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
