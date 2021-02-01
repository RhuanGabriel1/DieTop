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
    public partial class Register_ATV : Form
    {
        public Register_ATV()
        {
            InitializeComponent();
            selectTipo.SelectedIndex = 0;
        }

        private void ButtonVoltar_Click(object sender, EventArgs e)
        {
            Register_ATV here = new Register_ATV();
            Dashboard there= new Dashboard();
            this.Hide();
            this.Closed += (s, args) => here.Close();
            there.Show();
        }

        private void ButtonCadastrar_Click(object sender, EventArgs e)
        {
            Class.UserVar user = new Class.UserVar();
            db.Database data = new db.Database();
            data.CommandSQL("UPDATE dia SET tipo_atividade = '" + selectTipo.SelectedItem + "', duracao_atv = '" + inputTempo.Text+ "'WHERE cpf ='" + user.Cpf + "';");
        }
    }
}
