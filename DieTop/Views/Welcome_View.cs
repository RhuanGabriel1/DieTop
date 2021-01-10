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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Welcome_View_Load(object sender, EventArgs e)
        {

        }

        private void textWelcome_TextChanged(object sender, EventArgs e)
        {

        }

        private void welcomeText_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginInput_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void inputSenha_enter(object sender, EventArgs e)
        {
            changeInputTextClicked(inputSenha, "Insira sua Senha");

        }
        private void inputSenha_leave(object sender, EventArgs e)
        {
            changeInputTextClickedNull(inputSenha, "Insira sua Senha");

        }
        private void inputLogin_Enter(object sender, EventArgs e)
        {
            changeInputTextClicked(inputLogin, "Insira seu Login");

        }
        private void inputLogin_Leave(object sender, EventArgs e)
        {
            changeInputTextClickedNull(inputLogin, "Insira seu Login");

        }
        private void inputSenha_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
