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

        private void LoadingComponents()
        {
            string getComida1Name = "";
            string getComida2Name = "";
            string getComida3Name = "";
            int getComida1Cal = 0;
            int getComida2Cal = 0;
            int getComida3Cal = 0;
            int getComida1Index = -1;
            int getComida2Index = -1;
            int getComida3Index = -1;
            if (SelectA1.SelectedIndex != 0)
            {
                getComida1Name = SelectA1.Text;
                getComida1Index = SelectA1.SelectedIndex - 1;
                getComida1Cal = int.Parse(getCaloriasAli[getComida1Index]);
            }
            if (SelectA2.SelectedIndex != 0)
            {
                getComida2Name = SelectA2.Text;
                getComida2Index = SelectA2.SelectedIndex - 1;
                getComida2Cal = int.Parse(getCaloriasAli[getComida2Index]);

            }

            if (SelectA3.SelectedIndex != 0)
            {
                getComida3Name = SelectA3.Text;
                getComida3Index = SelectA3.SelectedIndex - 1;
                getComida3Cal = int.Parse(getCaloriasAli[getComida3Index]);

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


     
      

   

        private void ButtonAdicionarAlimento_Click(object sender, EventArgs e)
        {

            db.Database data = new db.Database();
            Class.UserVar userVar = new Class.UserVar();
            if (selectTipo.SelectedIndex == 0)
            {
                data.CommandSQL("update  dia set cafe_da_manha = '" + labelAli1.Text + "/" + labelAli2.Text + "/" + labelAli3.Text+ "', caloria_restante = '" + labelCalTotal.Text + "' where cpf ='" + userVar.Cpf + "';"); ;

            }
            if (selectTipo.SelectedIndex == 1)
            {
                data.CommandSQL("update  dia set almoco = '" + labelAli1.Text + "/" + labelAli2.Text + "/" + labelAli3.Text + "', caloria_restante = '" + labelCalTotal.Text + "' where cpf ='" + userVar.Cpf + "';"); ;


            }
            if (selectTipo.SelectedIndex == 2)
            {
                data.CommandSQL("update  dia set janta = '" + labelAli1.Text + "/" + labelAli2.Text + "/" + labelAli3.Text + "', caloria_restante = '" + labelCalTotal.Text + "' where cpf ='" + userVar.Cpf + "';"); ;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadingComponents();
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {

        }
    }
}
