using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DieTop
{
    public partial class Warning : Form
    {
        public Warning()
        {
            MaximizeBox = false;
            InitializeComponent();
        }

        private void ButtonAceitar(object sender, EventArgs e)
        {
            Warning warning = new Warning();
        Register_View.Register_View registerView = new Register_View.Register_View();
            this.Hide();
            this.Closed += (s, args) => warning.Close();
            registerView.Show();
        }

        private void ButtonVoltar(object sender, EventArgs e)
        {
            Warning warning = new Warning();
        Welcome_View welcome_View = new Welcome_View();
            this.Hide();
            this.Closed += (s, args) => warning.Close();
            welcome_View.Show();
        }
    }
}
