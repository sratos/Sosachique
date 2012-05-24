using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _2chReader
{
    static class Program
    {

        public static Form1 mForm { get; set; }
        public static bool sound { get; set; }
        public static bool ex { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 mForm = new Form1();
            sound = true;
            Application.Run(mForm);
        }
    }
}
