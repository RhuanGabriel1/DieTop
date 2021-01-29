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
    public partial class CreateFood : Form
    {


        public CreateFood()
        {
            InitializeComponent();
        }


        private void ButtonVoltar_Click_1(object sender, EventArgs e)
        {

            CreateFood here = new CreateFood();
            Dashboard dash = new Dashboard();
            this.Hide();
            this.Closed += (s, args) => here.Close();
            dash.Show();
        }

        private void ButtonAddNew_Click(object sender, EventArgs e)
        {
            Register_Food food = new Register_Food();
            CreateFood here = new CreateFood();
            this.Hide();
            this.Closed += (s, args) => here.Close();
            food.Show();
        }
    }
}
