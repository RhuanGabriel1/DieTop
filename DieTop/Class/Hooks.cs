using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hooks
{
    static class Hooks
    {
        //Set Method to do Where will appear the screen
  
        public static void StopAndStart(Form deleteView, Form startView)
        {
            deleteView.Hide();
            deleteView.Closed += (s, args) => deleteView.Close();
            startView.Show();

        }
        
    }
}
