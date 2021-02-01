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
                DataBase.Database  data = new DataBase.Database();
                bool queryRequest =  data.CommandSQL("UPDATE pessoa SET nome = '" + inputNome.Text + "', idade = '" + inputIdade.Text + "', sexo = '" + inputSexo.Text + "', altura = '" + inputAltura.Text +
                    "', peso = '" + inputPeso.Text + "' WHERE cpf ='" + dataUser.Cpf + "';");
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
            DataBase.Database data = new DataBase.Database();
            Class.UserVar user = new Class.UserVar();
            int day = int.Parse(user.Dia);
            day = day + 1;
            DialogResult result = MessageBox.Show("Os Seguintes Dados Serão Cadastrados : \n" + "Café da  Manhã : " + user.Cafe_da_manha + "\nAlmoço : " + user.Almoco +
                        "\nJanta : " + user.Janta + "\nTotal de Calorias : " + user.Total_calorias + "\nCalorias Restantes : " + user.Caloria_restante +
                        "\nTipo de Atividade Física : " + user.Tipo_atividade + "\nDieta : " + user.Dieta + "\nDuração da Atividade : " +
                        user.Duracao_atv + "\nAtividades Semanais: " + user.AtvSem+
                        "\n Deseja Prosseguir?", "Deseja Prosseguir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result.ToString() == "Yes")
            {
                
              bool  query= data.CommandSQL("insert into dia (cafe_da_manha,almoco,janta,total_calorias,caloria_restante,tipo_atividade,duracao_atv,cpf,dieta_dia,atv_dia,dia) values ('Nada','Nada','Nada','" + user.Total_calorias + "','" + user.Total_calorias + "','Nenhuma','0','" + user.Cpf + "', '" + user.Dieta + "', '" + user.AtvSem + "','"+day+"')");
                if (!query)
                {
                  
                        MessageBox.Show("Houve um Erro Durante o Cadastro! Favor entrar em contato com Suporte", "Muito Obrigado!"
                          , MessageBoxButtons.OK, MessageBoxIcon.Error);

                    
                    Dashboard here = new Dashboard();
                    this.Hide();
                    this.Closed += (s, args) => here.Close();
                    here.Show();
                }
                else
                {
                    MessageBox.Show("Cadastro Efetuado! Obrigado por Utilizar Dietop! Esperamos te ver Amanhã!", "Muito Obrigado!"
                                 , MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Application.Exit();
                }
            }
        }

        private void buttonBackDays_Click(object sender, EventArgs e)
        {
            Historic there= new Historic();
            Dashboard here = new Dashboard();
            this.Hide();
            this.Closed += (s, args) => here.Close();
            there.Show();
        }
    }
}
