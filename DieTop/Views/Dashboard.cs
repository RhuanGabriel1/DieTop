using System.Windows.Forms;

namespace DieTop.Views
{
    public partial class Dashboard : Form
    {

        Class.UserVar dataUser = new Class.UserVar();

        public Dashboard()
        {
            InitializeComponent();
            labelUserInformation.Text = "Segue suas Informações, " + dataUser.Nome+"!";

        }

     
    }
}
