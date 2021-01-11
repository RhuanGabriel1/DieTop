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
    }
}
