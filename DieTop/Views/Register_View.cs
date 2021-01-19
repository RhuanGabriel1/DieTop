using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register_View
{
    public partial class Register_View : Form
    {
        Hooks.Hooks hook = new Hooks.Hooks();
        public Register_View()
        {
            MaximizeBox = false;
            InitializeComponent();
        }

        private void handleCancelSubmit(object sender, EventArgs e)
        {
            DieTop.Welcome_View welcome = new DieTop.Welcome_View(); 


            this.Hide();
            this.Closed += (s, args) => this.Close();
            welcome.Show();
        }

        private void leaveNome(object sender, EventArgs e)
        {
            hook.ChangeInputTextClickedNull(inputNome,"Insira seu Nome");
        }

        private void onClickNome(object sender, EventArgs e)
        {
            hook.ChangeInputTextClicked(inputNome, "Insira seu Nome");

        }

        //Idade Attributes
        private void inputIIdadeClick(object sender, EventArgs e)
        {
            hook.ChangeInputTextClicked(inputIdade, "Insira sua Idade");
        }

        private void inputIdadeLeave(object sender, EventArgs e)
        {
            hook.ChangeInputTextClickedNull(inputIdade, "Insira sua Idade");
        }

        //Input Peso Attributes
        private void inputPesoEnter(object sender, EventArgs e)
        {
            hook.ChangeInputTextClicked(inputPeso, "Insira seu Peso");


        }
        private void inputPesoLeave(object sender, EventArgs e)
        {
            hook.ChangeInputTextClickedNull(inputPeso, "Insira seu Peso");

        }
        //Input Altura Attributes
        private void inputAlturaEnter(object sender, EventArgs e)
        {
            hook.ChangeInputTextClicked(inputAltura, "Insira sua Altura");

        }
        private void inputAlturaLeave(object sender, EventArgs e)
        {
            hook.ChangeInputTextClickedNull(inputAltura, "Insira sua Altura");

        }


        private void handleFormSubmit(object sender, EventArgs e)
        {

            if(inputSenha.Text == inputConfirmarSenha.Text)
            {
                //Usuário Logou

            }
            else
            {

            }
        }


       

        //Password Attributes

        private void inputClickSenha(object sender, EventArgs e)
        {

        }

        private void inputSenhaLeave(object sender, EventArgs e)
        {

        }

        //Confirm Password attributes
        private void inputConfirmaClick(object sender, EventArgs e)
        {

        }
        private void inputConfirmaLeave(object sender, EventArgs e)
        {

        }
        //Key press attributes
        private void inputNameKeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))

            {
                e.Handled = true;

            }
        }

        private void inputIdadeKeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void inputPesoKeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void inputAlturaKeyPress(object sender, KeyPressEventArgs e)
        {

        }

       
    }
}
