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

        protected void ChangeInputTextClicked(TextBox textBox, String text)
        {
            if (textBox.Text == text)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
                textBox.TextAlign = HorizontalAlignment.Left;
            }
        }
        //If clicked button text === "", will turn all for default
        protected void ChangeInputTextClickedNull(TextBox textBox, String text)
        {
            if (textBox.Text == "")
            {
                textBox.Text = text;
                textBox.ForeColor = Color.Silver;
                textBox.TextAlign = HorizontalAlignment.Center;
            }
        }

       //Quando Clica no input
        private void InputSenha_enter(object sender, EventArgs e)
        {
            ChangeInputTextClicked(inputSenha, "Insira sua Senha");

        }
        //Quando Sai do input e nao contém nenhum dado
        private void InputSenha_leave(object sender, EventArgs e)
        {
            ChangeInputTextClickedNull(inputSenha, "Insira sua Senha");

        }
        //Quando Clica no input

        private void InputLogin_Enter(object sender, EventArgs e)
        {
            ChangeInputTextClicked(inputLogin, "Insira seu Login");

        }
        //Quando Sai do input e nao contém nenhum dado

        private void InputLogin_Leave(object sender, EventArgs e)
        {
            ChangeInputTextClickedNull(inputLogin, "Insira seu Login");

        }

        private void LoadRegisterScreen(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Welcome_View welcome_View = new Welcome_View();
            Register_View.Register_View registerView = new Register_View.Register_View();
           
            Hooks.Hooks.StopAndStart(welcome_View,registerView);


        }
    }
}
