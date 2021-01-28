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
    public partial class Dashboard : Form
    {

        
        public Dashboard()
        {
            InitializeComponent();
            ChangeScreen();

        }

        private void ChangeScreen()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class.UserVar user = new Class.UserVar();
            Console.WriteLine(user.Cpf);
        }
    }
}
