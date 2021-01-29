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
    public partial class Register_Food : Form
    {
        public Register_Food()
        {
            InitializeComponent();
        }

        private void ButtonCadastrar_Click(object sender, EventArgs e)
        {
            db.Database data = new db.Database();
            data.CommandSQL("insert into alimento(nome_alim,calorias_alim) values('" + InputAlimento.Text + "','" + InputCaloria.Text +"');");
        }

        private void ButtonVoltar_Click(object sender, EventArgs e)
        {
            Register_Food here = new Register_Food();
            CreateFood food = new CreateFood();
            this.Hide();
            this.Closed += (s, args) => here.Close();
            food.Show();
        }
    }
}
