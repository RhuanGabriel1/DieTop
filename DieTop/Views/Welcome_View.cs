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
  

    public partial class Welcome_View : Form
    {
        public Welcome_View()
        {
            InitializeComponent();
        }
        //If clicked is different of default text , will turn of personalized text

        protected void changeInputTextClicked(TextBox textBox, String text)
        {
            if (textBox.Text == text)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
                textBox.TextAlign = HorizontalAlignment.Left;
            }
        }
        //If clicked button text === "", will turn all for default
        protected void changeInputTextClickedNull(TextBox textBox, String text)
        {
            if (textBox.Text == "")
            {
                textBox.Text = text;
                textBox.ForeColor = Color.Silver;
                textBox.TextAlign = HorizontalAlignment.Center;
            }
        }

       //Quando Clica no input
        private void inputSenha_enter(object sender, EventArgs e)
        {
            changeInputTextClicked(inputSenha, "Insira sua Senha");

        }
        //Quando Sai do input e nao contém nenhum dado
        private void inputSenha_leave(object sender, EventArgs e)
        {
            changeInputTextClickedNull(inputSenha, "Insira sua Senha");

        }
        //Quando Clica no input

        private void inputLogin_Enter(object sender, EventArgs e)
        {
            changeInputTextClicked(inputLogin, "Insira seu Login");

        }
        //Quando Sai do input e nao contém nenhum dado

        private void inputLogin_Leave(object sender, EventArgs e)
        {
            changeInputTextClickedNull(inputLogin, "Insira seu Login");

        }

        private void newRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Welcome_View welcome_View = new Welcome_View(); 
            Views.Register_View registerView = new Views.Register_View();
            //Fecha a Aba Welcome view
            welcome_View.Closed += (s, args) => this.Close();
            //Abre uma Nova tela (CADASTRO)
            registerView.Show();


        }
    }
}
