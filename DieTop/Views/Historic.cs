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
    public partial class Historic : Form
    {
   
        
        public Historic()
        {
            InitializeComponent();

            Class.UserVar userVar = new Class.UserVar();
            int day = int.Parse(userVar.Dia);
            for (int i = 1; i < day; i++)
            {
                selectDay.Items.AddRange(new object[] {
                i
                });
            }

            selectDay.SelectedIndex = 0 ;

            Refresh();
        }


      
        private void ButtonVoltar_Click(object sender, EventArgs e)
        {
            Historic here= new Historic();
            Dashboard there = new Dashboard();
            this.Hide();
            this.Closed += (s, args) => here.Close();
            there.Show();
        }

        private void Refresh()
        {
            DataBase.Database data = new DataBase.Database();
            List<string> getData = new List<string>();
            Class.UserVar user = new Class.UserVar();
            string day = selectDay.SelectedItem.ToString();
            getData = data.CommandSelectSQL("select cafe_da_manha, almoco, janta, total_calorias, caloria_restante, tipo_atividade, duracao_atv, dieta_dia, atv_dia, dia from dia where cpf = '" + user.Cpf + " ' and dia = '" + day + "' ; ");

            labelCafe.Text = getData[0];
            labelAlmoco.Text = getData[1];
            labelJanta.Text = getData[2];
            labelTotal.Text = getData[3];
            labelRestante.Text = getData[4];
            labelAtividade.Text = getData[5];
            labelDuracao.Text = getData[6];
            labelDieta.Text = getData[7];
            labelAtvSem.Text = getData[8];
            labelDia.Text = getData[9];

        }
        private void buttonAtt_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
