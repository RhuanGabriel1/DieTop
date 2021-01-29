using System;
using System.Windows.Forms;

namespace DieTop.Views
{
    public partial class Dashboard : Form
    {

        Class.UserVar dataUser = new Class.UserVar();

        public Dashboard()
        {
            MaximizeBox = false;
            InitializeComponent();
            RealTime();

        }

        public void RealTime()
        {
            dataUser.Populate();
            labelUserInformation.Text = "Segue suas Informações, " + dataUser.Nome + "!";
            inputNome.Text = dataUser.Nome;
            inputCPF.Text = dataUser.Cpf;
            inputIdade.Text = dataUser.Idade;
            inputSexo.Text = dataUser.Sexo;
            inputAltura.Text = dataUser.Altura;
            inputPeso.Text = dataUser.Peso;
            selectAtvFisica.SelectedItem = dataUser.AtvSem;
            selectDieta.SelectedItem = dataUser.Dieta;

        }

        public void TurnOn(Button buttonOn,Button buttonOn2,Button buttonOff)
        {
            buttonOn.Visible = true;
            buttonOn2.Visible = true;
            buttonOff.Visible = false;

            inputNome.Enabled = true;
            inputIdade.Enabled = true;
            inputSexo.Enabled = true;
            inputAltura.Enabled = true;
            inputPeso.Enabled = true;
            selectDieta.Enabled = true;
            selectAtvFisica.Enabled = true;

            RealTime();
        }
        public void TurnOff(Button buttonOff, Button buttonOff2, Button buttonOn)
        {
            buttonOn.Visible = true;
            buttonOff2.Visible = false;
            buttonOff.Visible = false;

            inputNome.Enabled = false;
            inputIdade.Enabled = false;
            inputSexo.Enabled = false;
            inputAltura.Enabled = false;
            inputPeso.Enabled = false;
            selectDieta.Enabled = false;
            selectAtvFisica.Enabled = false;

            RealTime();
        }

        private void ButtonAlterar_Click(object sender, EventArgs e)
        {
            TurnOn(ButtonAceitar,ButtonVoltar,ButtonAlterar);
        }

        private void ButtonAceitar_Click(object sender, EventArgs e)
        {

            //(cpf,senha, nome, idade, sexo, altura, peso,dieta,fisica) 

            try
            {
                db.Database data = new db.Database();
                data.CommandSQL("UPDATE pessoa SET nome = '" + inputNome.Text + "', idade = '" + inputIdade.Text + "', sexo = '" + inputSexo.Text + "', altura = '" + inputAltura.Text +
                    "', peso = '" + inputPeso.Text + "', dieta = '" + selectDieta.SelectedItem.ToString() + "', fisica = '" + selectAtvFisica.SelectedItem.ToString() +
                    "' WHERE cpf ='" + dataUser.Cpf + "';");
                Dashboard dash = new Dashboard();
               
                TurnOff(ButtonAceitar,ButtonVoltar,ButtonAlterar);



            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
            }

        private void ButtonVoltar_Click(object sender, EventArgs e)
        {

            TurnOff(ButtonAceitar, ButtonVoltar, ButtonAlterar);
        }
    }
}
