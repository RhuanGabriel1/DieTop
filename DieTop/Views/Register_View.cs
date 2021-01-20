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
        //Get Default Texts
        string nomeDefault = "Insira seu Nome";
        string idadeDefault = "Insira sua Idade";
        string pesoDefault = "Insira seu Peso em KG";
        string alturaDefault = "Insira sua Altura";
        string senhaDefault = "Insira sua Senha";
        string confirmarDefault = "Confirme sua Senha";


        //Get of all these inputs
        public string getNome()
        {
            return inputNome.Text;
        }

        public string getIdade()
        {
            return inputIdade.Text;
        }
        public string getSexo()
        {
            if(radioMacho.Checked == true)
            {
            return "Macho";
            }
            else
            {
                return "Femêa";
            }
        }
        public string getPeso()
        {
            return inputPeso.Text;
        }
        public string getAltura()
        {
            return inputAltura.Text;
        }
        public string getSenha()
        {
            return inputSenha.Text;
        }
        public string getConfirmarSenha()
        {
            return inputConfirmarSenha.Text;
        }

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
            hook.ChangeInputTextClickedNull(inputNome,nomeDefault);
        }

        private void onClickNome(object sender, EventArgs e)
        {
            hook.ChangeInputTextClicked(inputNome, nomeDefault);

        }

        //Idade Attributes
        private void inputIIdadeClick(object sender, EventArgs e)
        {
            hook.ChangeInputTextClicked(inputIdade, idadeDefault);
        }

        private void inputIdadeLeave(object sender, EventArgs e)
        {
            hook.ChangeInputTextClickedNull(inputIdade, idadeDefault);
        }

        //Input Peso Attributes
        private void inputPesoEnter(object sender, EventArgs e)
        {
            hook.ChangeInputTextClicked(inputPeso, pesoDefault);


        }
        private void inputPesoLeave(object sender, EventArgs e)
        {
            hook.ChangeInputTextClickedNull(inputPeso, pesoDefault);

        }
        //Input Altura Attributes
        private void inputAlturaEnter(object sender, EventArgs e)
        {
            hook.ChangeInputTextClicked(inputAltura, alturaDefault);

        }
        private void inputAlturaLeave(object sender, EventArgs e)
        {
            hook.ChangeInputTextClickedNull(inputAltura, alturaDefault);

        }

        //Input Senha
        private void inputSenhaEnter(object sender, EventArgs e)
        {
            hook.ChangeInputTextClicked(inputSenha, senhaDefault);
            hook.TurnItToPassword(inputSenha, senhaDefault);


        }


        private void inputSenhaLeave(object sender, EventArgs e)
        {
            hook.ChangeInputTextClickedNull(inputSenha, senhaDefault);
            hook.TurnItToPassword(inputSenha, senhaDefault);


        }
        //Input Confirmar Senha

        private void inputConfirmaEnter(object sender, EventArgs e)
        {
            hook.ChangeInputTextClicked(inputConfirmarSenha, confirmarDefault);
            hook.TurnItToPassword(inputConfirmarSenha, confirmarDefault);

        }

        private void inputConfirmaLeave(object sender, EventArgs e)
        {
            hook.ChangeInputTextClickedNull(inputConfirmarSenha, confirmarDefault);
            hook.TurnItToPassword(inputConfirmarSenha, confirmarDefault);

        }




        //Form Submit ( Envio de Formulário)

        private void handleFormSubmit(object sender, EventArgs e)
        //Fazer toda uma Verificação antes de Cadastrar.
        {
            bool correct = true;
            correct = hook.FormValidator(correct,1,getNome(),nomeDefault,2);
            correct = hook.FormValidator(correct, 0, getIdade(), idadeDefault, 4);
            correct = hook.FormValidator(correct, 0, getPeso(), pesoDefault, 4);
            correct = hook.FormValidator(correct, 0, getAltura(), alturaDefault, 4);


            if (int.Parse(getPeso()) > 400)
            {
                correct = false;
                MessageBox.Show("Peso Inválido/ PROCURE UM MÉDICO URGENTEMENTE");
            }


            if (correct)
            {
                if (getSenha()==getConfirmarSenha())
                {
                    //\
                    MessageBox.Show("Nome : " + getNome()+ "\nIdade : "+getIdade()+ "\nSexo : "+getSexo()+ "\nPeso : "+getPeso()+ "\nAltura : "+getAltura()+ "\nSenha : "+getSenha());
                }
                else
                {
                    MessageBox.Show("As Senhas Diferem!");

                }
            }
            else
            {
                MessageBox.Show("Erro de Formulário, Favor Revisar!");


            }
        }


        //Key press attributes
        private void inputNameKeyPress(object sender, KeyPressEventArgs e)
        {
            inputNome.Text = hook.AcceptOnlyLetters(e,getNome());
        }

        private void inputIdadeKeyPress(object sender, KeyPressEventArgs e)
        {
            inputIdade.Text = hook.AcceptOnlyNumbers(e,getIdade());

        }

        private void inputPesoKeyPress(object sender, KeyPressEventArgs e)
        {
           inputPeso.Text = hook.AcceptOnlyNumbers(e,getPeso());

        }

        private void inputAlturaKeyPress(object sender, KeyPressEventArgs e)
        {
           inputAltura.Text =  hook.AcceptOnlyNumbers(e,getAltura());

        }


    }
}
