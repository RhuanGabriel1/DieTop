﻿using System;
using System.Windows.Forms;

namespace DieTop
{
    static class App
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DataBase.Database data = new DataBase.Database();
            data.ConnectDB();
            
            Application.Run(new Welcome_View());


        }
    }
}
