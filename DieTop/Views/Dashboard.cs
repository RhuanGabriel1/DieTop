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

     
    }
}
