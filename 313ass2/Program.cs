﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _313ass2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Form1 mainForm = ;
            Application.Run(new Form1());


        }
    }
}
