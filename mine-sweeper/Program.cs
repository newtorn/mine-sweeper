using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace mine_sweeper
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Loadscreen());
        }
        public static void startGame() {

        }
    }
}
