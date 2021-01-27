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
            MaximizeBox = false;
            InitializeComponent();
            SendLogin();
        }

       

        List<string> getData = new List<string>();
      

        //If clicked is different of default text , will turn of personalized text
        Hooks.Hooks hook = new Hooks.Hooks();
       

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
        private List<string> SendLogin()
        {
            return getData;
        }
        private void LoadRegisterScreen(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Welcome_View welcome_View = new Welcome_View();
            Register_View.Register_View registerView = new Register_View.Register_View();

            this.Hide();
            this.Closed += (s, args) => welcome_View.Close();
            registerView.Show();
            getData.Add(inputLogin.Text);
            getData.Add(inputSenha.Text);

        }
       
        //HandleFormSubmit
        private void loginButton_Click(object sender, EventArgs e)
        {
            List<string> getData = new List<string>();

            db.Database data = new db.Database();

            //getData = data.CommandSelectSQL("select cpf,senha,nome from pessoa where cpf = '" + inputLogin.Text+"' and senha ='"+inputSenha.Text+"'");
            Class.UserVar userAttributes = new Class.UserVar();
            getData = userAttributes.returnLogin("select cpf,senha,nome from pessoa where cpf = '" + inputLogin.Text + "' and senha ='" + inputSenha.Text + "'");
            if (getData.Count != 0)
            {
                Views.Dashboard userView = new Views.Dashboard();
                Welcome_View welcome_View = new Welcome_View();

                this.Hide();
                this.Closed += (s, args) => welcome_View.Close();
                userView.Show();
                MessageBox.Show("Logado com Sucesso! Seja Bem-vindo , " + getData[2], "Seu Login foi Efetuado!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                MessageBox.Show("Login ou Senha Incorretos!", "Seu Login foi mal Sucedido!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
