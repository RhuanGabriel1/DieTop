using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DieTop.Views
{
    public partial class Historic : Form
    {
   
        
        public Historic()
        {
            InitializeComponent();

            Class.UserVar userVar = new Class.UserVar();
            int day = int.Parse(userVar.Dia);
            for (int i = 1; i < day; i++)
            {
                selectDay.Items.AddRange(new object[] {
                i
                });
            }

            selectDay.SelectedIndex = 0 ;
            

        }

      
        private void ButtonVoltar_Click(object sender, EventArgs e)
        {
            Historic here= new Historic();
            Dashboard there = new Dashboard();
            this.Hide();
            this.Closed += (s, args) => here.Close();
            there.Show();
        }
    }
}
