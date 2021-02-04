using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DieTop
{
  

    public partial class Welcome_View : Form
    {

        Hooks.Hooks hook = new Hooks.Hooks();

        public Welcome_View()
        {
            MaximizeBox = false;
            InitializeComponent();
            
        }

    
    
        //If clicked is different of default text , will turn of personalized text
       

       //Quando Clica no input
        private void InputSenha_enter(object sender, EventArgs e)
        {
           hook.ChangeInputTextClicked(inputSenha, "Insira sua Senha");
           hook.TurnItToPassword(inputSenha, "Insira sua Senha");

        }
        //Quando Sai do input e nao contém nenhum dado
        private void InputSenha_leave(object sender, EventArgs e)
        {
            hook.ChangeInputTextClickedNull(inputSenha, "Insira sua Senha");
            hook.TurnItToPassword(inputSenha, "Insira sua Senha");


        }
        //Quando Clica no input

        private void InputLogin_Enter(object sender, EventArgs e)
        {
            hook.ChangeInputTextClicked(inputLogin, "Insira seu CPF");

        }
        //Quando Sai do input e nao contém nenhum dado

        private void InputLogin_Leave(object sender, EventArgs e)
        {
            hook.ChangeInputTextClickedNull(inputLogin, "Insira seu CPF");

        }
        
        private void LoadRegisterScreen(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Welcome_View welcome_View = new Welcome_View();
            Warning warning = new Warning();
            this.Hide();
            this.Closed += (s, args) => welcome_View.Close();
            warning.Show();
          

        }

        //HandleFormSubmit


        private void loginButton_Click(object sender, EventArgs e)
        {
            List<string> getData = new List<string>();
            DataBase.Database data = new DataBase.Database();


            List<string> day = new List<string>();
            day = data.CommandSelectSQL("select MAX(dia) from dia where cpf = '" + inputLogin.Text + "';");
            getData = data.CommandSelectSQL("select cpf,senha,nome from pessoa where cpf = '" + inputLogin.Text + "' and senha ='" + inputSenha.Text + "'");

            if (getData.Count != 0)
            {
                Class.UserVar.CPF_LOGIN = getData[0];
                Class.UserVar.SENHA_LOGIN = getData[1];
                Class.UserVar.TODAY = day[0];

                Views.Dashboard userView = new Views.Dashboard();
                Welcome_View welcome_View = new Welcome_View();
                this.Hide();
                this.Closed += (s, args) => welcome_View.Close();
                userView.Show();


            }
            else
            {
                MessageBox.Show("Login ou Senha Incorretos!", "Seu Login foi mal Sucedido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
