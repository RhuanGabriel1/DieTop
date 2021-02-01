using System;
using System.Collections.Generic;
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
            Refresh();

        }


        private void Refresh()
        {
            Class.UserVar user = new Class.UserVar();
            Console.WriteLine(user.Cafe_da_manha);
            Console.WriteLine(user.Almoco);
            Console.WriteLine(user.Janta);
            Console.WriteLine(user.Total_calorias);
            Console.WriteLine(user.Caloria_restante);
            Console.WriteLine(user.Tipo_atividade);
            Console.WriteLine(user.Duracao_atv);
            Console.WriteLine(user.AtvSem);
            Console.WriteLine(user.Dia);

            try
            {
            labelDia.Text = user.Dia;
            labelCafe.Text = user.Cafe_da_manha;
            labelAlmoco.Text = user.Almoco;
            labelJanta.Text = user.Janta;
            labelTotal.Text = user.Total_calorias;
            labelRestante.Text = user.Caloria_restante;
            labelAtividade.Text = user.Tipo_atividade;
            labelDieta.Text = user.Dieta;
            labelDuracao.Text = user.Duracao_atv;
            labelAtvSem.Text = user.AtvSem;

                labelDia.Visible = true;
                labelCafe.Visible = true;
                labelAlmoco.Visible = true;
                labelJanta.Visible= true;
                labelTotal.Visible = true;
                labelRestante.Visible = true;
                labelAtividade.Visible = true;
                labelDieta.Visible = true;
                labelDuracao.Visible = true;
                labelAtvSem.Visible = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                labelDia.Visible = false;
                labelCafe.Visible = false;
                labelAlmoco.Visible = false;
                labelJanta.Visible = false;
                labelTotal.Visible = false;
                labelRestante.Visible = false;
                labelAtividade.Visible = false;
                labelDieta.Visible = false;
                labelDuracao.Visible = false;
                labelAtvSem.Visible = false;
            }
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
            //selectAtvFisica.SelectedItem = dataUser.AtvSem;
            //selectDieta.SelectedItem = dataUser.Dieta;

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
             bool queryRequest =  data.CommandSQL("UPDATE pessoa SET nome = '" + inputNome.Text + "', idade = '" + inputIdade.Text + "', sexo = '" + inputSexo.Text + "', altura = '" + inputAltura.Text +
                    "', peso = '" + inputPeso.Text + "', dieta = '" +
                    "' WHERE cpf ='" + dataUser.Cpf + "';");
                Dashboard dash = new Dashboard();
               

                if (queryRequest)
                {
                    TurnOff(ButtonAceitar, ButtonVoltar, ButtonAlterar);
                    MessageBox.Show("Alteração Efetuada!", "Muito Obrigado!"
                                                      , MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {

                }


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

        private void ButtonRefeicao_Click(object sender, EventArgs e)
        {
            CreateFood food = new CreateFood();
            Dashboard here= new Dashboard();
            this.Hide();
            this.Closed += (s, args) => here.Close();
            food.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register_ATV atividade = new Register_ATV();
            Dashboard here = new Dashboard();
            this.Hide();
            this.Closed += (s, args) => here.Close();
            atividade.Show();
        }

        private void ButtonFinalizar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
