using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DieTop.Views
{
    public partial class CreateFood : Form
    {
        List<string> getNomeAli = new List<string>();
        List<string> getCaloriasAli = new List<string>();

        public CreateFood()
        {
            InitializeComponent();
            ReceiveData();
            for (int i = 0; i < getNomeAli.Count; i++)
            {
                SelectA1.Items.AddRange(new object[] {
                getNomeAli[i]
                });
                SelectA2.Items.AddRange(new object[] {
                getNomeAli[i]
                });
                SelectA3.Items.AddRange(new object[] {
                getNomeAli[i]
                });
            }
            selectTipo.SelectedIndex = 0;
            SelectA1.SelectedIndex = 0;
            SelectA2.SelectedIndex = 0;
            SelectA3.SelectedIndex = 0;

        }


        private void ReceiveData()
        {
            db.Database dataZ = new db.Database();
            getNomeAli = dataZ.CommandSelectSQL("select nome_alim from alimento ");
            getCaloriasAli = dataZ.CommandSelectSQL("select calorias_alim from alimento ");
           
        }

        private void RealTimeLabels()
        {
            string getComida1Name = "";
            string getComida2Name = "";
            string getComida3Name = "";
            string getComida1Cal = "";
            string getComida2Cal = "";
            string getComida3Cal = "";
            int getComida1Index = -1;
            int getComida2Index = -1;
            int getComida3Index = -1;
            if (SelectA1.SelectedIndex != 0)
            {
                getComida1Name = SelectA1.Text;
                getComida1Index = SelectA1.SelectedIndex - 1;
                getComida1Cal = getCaloriasAli[getComida1Index];
            }
            if (SelectA2.SelectedIndex != 0)
            {
                getComida2Name = SelectA2.Text;
                getComida2Index = SelectA2.SelectedIndex - 1;
                getComida2Cal = getCaloriasAli[getComida2Index];

            }

            if (SelectA3.SelectedIndex != 0)
            {
                getComida3Name = SelectA3.Text;
                getComida3Index = SelectA3.SelectedIndex - 1;
                getComida3Cal = getCaloriasAli[getComida3Index];

            }
            Hooks.Hooks hook = new Hooks.Hooks();
            hook.RealTimeCal(getComida1Name, getComida2Name, getComida3Name, getComida1Cal, getComida2Cal, getComida3Cal, labelAli1, labelAli2, labelAli3, labelCal1, labelCal2, labelCal3, labelCalTotal);
        }


        private void ButtonVoltar_Click_1(object sender, EventArgs e)
        {

            CreateFood here = new CreateFood();
            Dashboard dash = new Dashboard();
            this.Hide();
            this.Closed += (s, args) => here.Close();
            dash.Show();
        }

        private void ButtonAddNew_Click(object sender, EventArgs e)
        {
            Register_Food food = new Register_Food();
            CreateFood here = new CreateFood();
            this.Hide();
            this.Closed += (s, args) => here.Close();
            food.Show();
        }


     
      

        private void ali1Hover(object sender, EventArgs e)
        {
            RealTimeLabels();

        }

        private void painelHover(object sender, EventArgs e)
        {
            RealTimeLabels();

        }

        private void ali2Hover(object sender, EventArgs e)
        {
            RealTimeLabels();

        }

        private void ali3Hover(object sender, EventArgs e)
        {
            RealTimeLabels();

        }

        private void ButtonAddHover(object sender, EventArgs e)
        {
            RealTimeLabels();

        }
    }
}
