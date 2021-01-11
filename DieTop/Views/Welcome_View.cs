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
        Hooks.Hooks hook = new Hooks.Hooks();
       

       //Quando Clica no input
        private void InputSenha_enter(object sender, EventArgs e)
        {
           hook.ChangeInputTextClicked(inputSenha, "Insira sua Senha");

        }
        //Quando Sai do input e nao contém nenhum dado
        private void InputSenha_leave(object sender, EventArgs e)
        {
            hook.ChangeInputTextClickedNull(inputSenha, "Insira sua Senha");

        }
        //Quando Clica no input

        private void InputLogin_Enter(object sender, EventArgs e)
        {
            hook.ChangeInputTextClicked(inputLogin, "Insira seu Login");

        }
        //Quando Sai do input e nao contém nenhum dado

        private void InputLogin_Leave(object sender, EventArgs e)
        {
            hook.ChangeInputTextClickedNull(inputLogin, "Insira seu Login");

        }

        private void LoadRegisterScreen(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Welcome_View welcome_View = new Welcome_View();
            Register_View.Register_View registerView = new Register_View.Register_View();

            this.Hide();
            this.Closed += (s, args) => welcome_View.Close();
            registerView.Show();


        }

     
    }
}
