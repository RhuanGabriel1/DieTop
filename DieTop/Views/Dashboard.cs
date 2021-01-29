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
            labelUserInformation.Text = "Segue suas Informações, " + dataUser.Nome+"!";
            inputNome.Text = dataUser.Nome;
            inputCPF.Text = dataUser.Cpf;
            inputIdade.Text = dataUser.Idade;
            inputSexo.Text = dataUser.Sexo;
            inputAltura.Text = dataUser.Altura;
            inputPeso.Text = dataUser.Peso;

        }

        public void TurnOn(Button buttonOn,Button buttonOn2,Button buttonOff)
        {
            buttonOn.Visible = true;
            buttonOn2.Visible = true;
            buttonOff.Visible = false;

            inputNome.Enabled = true;
            inputCPF.Enabled = true;
            inputIdade.Enabled = true;
            inputSexo.Enabled = true;
            inputAltura.Enabled = true;
            inputPeso.Enabled = true;
            selectDieta.Enabled = true;
            selectAtvFisica.Enabled = true;
        }
        public void TurnOff(Button buttonOff, Button buttonOff2, Button buttonOn)
        {
            buttonOn.Visible = true;
            buttonOff2.Visible = false;
            buttonOff.Visible = false;

            inputNome.Enabled = false;
            inputCPF.Enabled = false;
            inputIdade.Enabled = false;
            inputSexo.Enabled = false;
            inputAltura.Enabled = false;
            inputPeso.Enabled = false;
            selectDieta.Enabled = false;
            selectAtvFisica.Enabled = false;

        }

        private void ButtonAlterar_Click(object sender, System.EventArgs e)
        {
            TurnOn(ButtonAceitar,ButtonVoltar,ButtonAlterar);
        }

        private void ButtonAceitar_Click(object sender, System.EventArgs e)
        {
            TurnOff(ButtonAceitar,ButtonVoltar,ButtonAlterar);

        }

        private void ButtonVoltar_Click(object sender, System.EventArgs e)
        {

            TurnOff(ButtonAceitar, ButtonVoltar, ButtonAlterar);
        }
    }
}
