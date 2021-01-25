using System;
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

            db.Database data = new db.Database();
            try
            {
            data.ConnectDB();
            }
            
            
            catch (Exception e)
            {
                data.CloseConnection();
                Application.Exit();

            }

            Application.Run(new Welcome_View());


        }
    }
}
