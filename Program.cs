﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMART_Table_Activty_Exporter
{
    static class Program
    {
        public static string PROGRAM_IDENTIFIER = "STT Exporter";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        public static void HandleError(Exception e)
        {
            System.Windows.Forms.MessageBox.Show("Error! Message: " + e.Message);
        }
    }
}
