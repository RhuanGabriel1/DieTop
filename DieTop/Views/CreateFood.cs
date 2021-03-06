﻿using System;
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

            LoadingComponents();


        }


        private void ReceiveData()
        {
            DataBase.Database  dataZ = new DataBase.Database() ;
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
            LoadingComponents();

            DataBase.Database data = new DataBase.Database();
            Class.UserVar userVar = new Class.UserVar();

            string ali1, ali2, ali3;
            ali1 = labelAli1.Text;
            ali2 = labelAli2.Text;
            ali3 = labelAli3.Text;

           

            if (ali1 == "Alimento1")
            {
                ali1 = "Nadinha";
            }
            if (ali2 == "Alimento2")
            {
                ali2 = "Nadinha";
            }
            if (ali3 == "Alimento3")
            {
                ali3 = "Nadinha";
            }

            bool error = false;
            if (int.Parse(labelCalTotal.Text) <=0)
            {
            DialogResult validation = MessageBox.Show("Parece que você estourará a quantidade de Calorias Proposta pelo programa, Deseja Continuar?", "WHAT????", MessageBoxButtons.YesNo,MessageBoxIcon.Error); ;
                if (validation.ToString() == "Yes")
                {
                    error = false;
                }
                else
                {
                    error = true;
                }
            }


            if (error)
            {
                selectTipo.SelectedIndex = 0;
                SelectA1.SelectedIndex = 0;
                SelectA2.SelectedIndex = 0;
                SelectA3.SelectedIndex = 0;
                LoadingComponents();

                return;
            }
            else
            {

                DialogResult result = MessageBox.Show("Os Seguinte Alimentos Serão Cadastrados : \n" + ali1 + "/" + ali2 + "/" + ali3 + "\n Deseja Prosseguir?", "Deseja Prosseguir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result.ToString() == "Yes")
                {
                    userVar.Connect();



                    if (selectTipo.SelectedIndex == 0)
                    {
                        if (userVar.Cafe_da_manha == "Nada")
                        {
                            data.CommandSQL("update  dia set cafe_da_manha = '" + ali1 + "/" + ali2 + "/" + ali3 + "', caloria_restante = '" + labelCalTotal.Text + "' where cpf ='" + userVar.Cpf + "' and dia = '" + userVar.Dia + "';");

                        }
                        else
                        {
                            MessageBox.Show("Parece que Você Já Realizou essa Refeição hoje! ", " Ação Indisponível.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }



                    if (selectTipo.SelectedIndex == 1)
                    {
                        if (userVar.Almoco == "Nada")
                        {
                            data.CommandSQL("update  dia set almoco = '" + ali1 + "/" + ali2 + "/" + ali3 + "', caloria_restante = '" + labelCalTotal.Text + "' where cpf ='" + userVar.Cpf + "' and dia = '" + userVar.Dia + "';");


                        }
                        else
                        {
                            MessageBox.Show("Parece que Você Já Realizou essa Refeição hoje! ", " Ação Indisponível.", MessageBoxButtons.OK, MessageBoxIcon.Error);


                        }
                    }


                    if (selectTipo.SelectedIndex == 2)
                    {
                        if (userVar.Janta == "Nada")
                        {
                            data.CommandSQL("update  dia set janta = '" + ali1 + "/" + ali2 + "/" + ali3 + "', caloria_restante = '" + labelCalTotal.Text + "' where cpf ='" + userVar.Cpf + "' and dia = '" + userVar.Dia + "';");

                        }
                        else
                        {
                            MessageBox.Show("Parece que Você Já Realizou essa Refeição hoje! ", " Ação Indisponível.", MessageBoxButtons.OK, MessageBoxIcon.Error);


                        }
                    }


                    selectTipo.SelectedIndex = 0;
                    SelectA1.SelectedIndex = 0;
                    SelectA2.SelectedIndex = 0;
                    SelectA3.SelectedIndex = 0;

                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadingComponents();
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            DataBase.Database  data = new DataBase.Database();
            Class.UserVar userVar = new Class.UserVar();
            DialogResult result = MessageBox.Show("Deseja Resetar Todas as Refeições?", "MENSAGEM DE ALERTA!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

          

            if (result.ToString() == "Yes")
            {

                data.CommandSQL("UPDATE dia SET almoco = 'Nada', cafe_da_manha = 'Nada' , janta = 'Nada', caloria_restante = '" + userVar.Total_calorias + "' WHERE cpf ='" + userVar.Cpf +
                    "' and dia = '" + userVar.Dia + "';");

                selectTipo.SelectedIndex = 0;
                SelectA1.SelectedIndex = 0;
                SelectA2.SelectedIndex = 0;
                SelectA3.SelectedIndex = 0;
                LoadingComponents();
            }




        }

        private void buttonAtt1_Click(object sender, EventArgs e)
        {
            LoadingComponents();
        }

        private void buttonAtt2_Click(object sender, EventArgs e)
        {
            LoadingComponents();
        }

        private void buttonAtt3_Click(object sender, EventArgs e)
        {
            LoadingComponents();
        }

        private void buttonAtt4_Click(object sender, EventArgs e)
        {
            LoadingComponents();
        }
    }
}
