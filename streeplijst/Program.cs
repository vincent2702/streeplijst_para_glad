﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace streeplijst
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
            FormList formlist = new FormList();
            runBatFile runBat = new runBatFile();
            //var reader = new ArduinoSerialReader("COM3");
            //Console.ReadLine();
            Application.Run();
        }

    }
}
