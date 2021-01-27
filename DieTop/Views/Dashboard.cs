using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DieTop.Views
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            ChangeScreen();
        }
        Welcome_View welcome = new Welcome_View();
        List<string> getUserLogin = new List<string>();
        Class.UserVar userData = new Class.UserVar();
     

        private void ChangeScreen()
        {
            userData.SettingAttribuites();
            labelUserInformation.Text = "Segue suas Informações, " + userData.getNome();
        }
    }
}
