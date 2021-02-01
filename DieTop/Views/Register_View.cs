using System;
using System.Windows.Forms;

namespace Register_View
{
    public partial class Register_View : Form
    {
        //Get Default Texts
        string nomeDefault = "Insira seu Nome";
        string idadeDefault = "Insira sua Idade";
        string pesoDefault = "Insira seu Peso em KG";
        string alturaDefault = "Insira sua Altura";
        string senhaDefault = "Insira sua Senha";
        string confirmarDefault = "Confirme sua Senha";
        string cpfDefault = "Insira seu CPF";




        //Get of all these inputs
        public string getNome()
        {
            return inputNome.Text;
        }

        public string getIdade()
        {
            return inputIdade.Text;
        }
        public string getSexo()
        {
            if(radioMacho.Checked == true)
            {
            return "Masculino";
            }
            else
            {
                return "Feminino";
            }
        }
        public string getPeso()
        {
            return inputPeso.Text;
        }
        public string getAltura()
        {
            return inputAltura.Text;
        }
        public string getCPF()
        {
            return inputCPF.Text;
        }
        public string getSenha()
        {
            return inputSenha.Text;
        }
        public string getConfirmarSenha()
        {
            return inputConfirmarSenha.Text;
        }

        Hooks.Hooks hook = new Hooks.Hooks();
        public Register_View()
        {
            MaximizeBox = false;
            InitializeComponent();

            selectAtvFisica.SelectedIndex = 0;
            selectDieta.SelectedIndex = 0;
        }

        private void handleCancelSubmit(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja Voltar para a Tela de Login?", "MENSAGEM DE ALERTA!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.ToString() == "Yes")
            {
                DieTop.Welcome_View welcome = new DieTop.Welcome_View();
                this.Hide();
                this.Closed += (s, args) => this.Close();
                welcome.Show();
            }
        }

        private void leaveNome(object sender, EventArgs e)
        {
            hook.ChangeInputTextClickedNull(inputNome,nomeDefault);
        }

        private void onClickNome(object sender, EventArgs e)
        {
            hook.ChangeInputTextClicked(inputNome, nomeDefault);

        }

        //Idade Attributes
        private void inputIIdadeClick(object sender, EventArgs e)
        {
            hook.ChangeInputTextClicked(inputIdade, idadeDefault);
        }

        private void inputIdadeLeave(object sender, EventArgs e)
        {
            hook.ChangeInputTextClickedNull(inputIdade, idadeDefault);
        }

        //Input Peso Attributes
        private void inputPesoEnter(object sender, EventArgs e)
        {
            hook.ChangeInputTextClicked(inputPeso, pesoDefault);


        }
        private void inputPesoLeave(object sender, EventArgs e)
        {
            hook.ChangeInputTextClickedNull(inputPeso, pesoDefault);

        }
        //Input Altura Attributes
        private void inputAlturaEnter(object sender, EventArgs e)
        {
            hook.ChangeInputTextClicked(inputAltura, alturaDefault);
        }
        private void inputAlturaLeave(object sender, EventArgs e)
        {
            hook.ChangeInputTextClickedNull(inputAltura, alturaDefault);
        }

        //Input Senha
        private void inputSenhaEnter(object sender, EventArgs e)
        {
            hook.ChangeInputTextClicked(inputSenha, senhaDefault);
            hook.TurnItToPassword(inputSenha, senhaDefault);
        }

        private void inputSenhaLeave(object sender, EventArgs e)
        {
            hook.ChangeInputTextClickedNull(inputSenha, senhaDefault);
            hook.TurnItToPassword(inputSenha, senhaDefault);

        }
        //Input Confirmar Senha

        private void inputConfirmaEnter(object sender, EventArgs e)
        {
            hook.ChangeInputTextClicked(inputConfirmarSenha, confirmarDefault);
            hook.TurnItToPassword(inputConfirmarSenha, confirmarDefault);

        }

        private void inputConfirmaLeave(object sender, EventArgs e)
        {
            hook.ChangeInputTextClickedNull(inputConfirmarSenha, confirmarDefault);
            hook.TurnItToPassword(inputConfirmarSenha, confirmarDefault);

        }

        private void inputEnterCPF(object sender, EventArgs e)
        {
            hook.ChangeInputTextClicked(inputCPF, cpfDefault);
        }
        private void inputLeaveCPF(object sender, EventArgs e)
        {
            hook.ChangeInputTextClickedNull(inputCPF, cpfDefault);
        }


        //Form Submit ( Envio de Formulário)

        
        private double ChangeCalories()
        {
            int getAtvFisCalc = selectAtvFisica.SelectedIndex;
            int getDietaCalc = selectDieta.SelectedIndex;
            //Não pratica
            if (getAtvFisCalc == 0)
            {
               return 1.2;
                //1 a 3 
            }else if (getAtvFisCalc == 1)
            {
                return 1.375;
                //4 a 6
            }else if (getAtvFisCalc == 2)
            {
                return 1.550;
                //7+
            }else if (getAtvFisCalc == 3)
            {
                return 1.725;
            }
            else
            {
                return 0.0;
            }
            return 0.0;
            }

        private double ChangeCaloriesSexo()
        {
            

            if (getSexo() == "Masculino")
            {
                return (66.5+(13.8*int.Parse(getPeso()))+(5*(int.Parse(getAltura())))-(6.8*int.Parse(getIdade())));
            }
            else
            {
                return  (65.51 + (9.5 * int.Parse(getPeso())) + (1.8 * (int.Parse(getAltura()))) - (4.7 * int.Parse(getIdade())));
            }
        }

        private double GetChanges()
        {
            //Ganhar peso
            if (selectDieta.SelectedIndex == 0)
            {
                return (ChangeCaloriesSexo() * ChangeCalories())+500;

                //Manter Peso
            }
            else if (selectDieta.SelectedIndex == 1)
            {

                return (ChangeCaloriesSexo() * ChangeCalories());

                //Perder Peso
            }
            else 
            {
                return (ChangeCaloriesSexo() * ChangeCalories()) - 500;
            }
        }

        

        private void handleFormSubmit(object sender, EventArgs e)
        //Fazer toda uma Verificação antes de Cadastrar.
        {
            double getChanges = GetChanges();

            bool stop = false;
            bool correct = true;
            correct = hook.FormValidator(correct,1,getNome(),nomeDefault,2);
            correct = hook.FormValidator(correct, 0, getIdade(), idadeDefault, 4);
            correct = hook.FormValidator(correct, 0, getPeso(), pesoDefault, 4);
            correct = hook.FormValidator(correct, 0, getAltura(), alturaDefault, 4);

            if (getCPF().Contains("Insira") || getCPF().Length <3)
            {
                correct = false;
            }

            if (getPeso() != "" && getPeso() != pesoDefault)
            {
                if (int.Parse(getPeso()) > 400)
                {
                    correct = false;
                    stop = true;
                    MessageBox.Show("Peso Inválido/ PROCURE UM MÉDICO URGENTEMENTE","Favor Procurar um Médico!!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }

            if (correct)
            {
                if (getSenha() == getConfirmarSenha())
                {
                    //\
                    //Consegue pegar os Dados 
                    //Passar para o banco
                    //Input data: getNome()  getIdade()  getSexo() getPeso() getAltura() getSenha()

                   DialogResult result = MessageBox.Show("Os Seguintes Dados Serão Cadastrados : \n" + "Nome : " + getNome() + "\nIdade : " + getIdade() + 
                        "\nSexo : " + getSexo() + "\nPeso : " + getPeso() + "\nCPF : " + getCPF() + "\nAltura : " + getAltura() + "\nSenha : " + "*"+"\n Deseja Prosseguir?","Deseja Prosseguir?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                    if (result.ToString() == "Yes" )
                    {
                        DieTop.db.Database data = new DieTop.db.Database();
                        try
                        {
                            bool queryError = false;
                            bool queryError2 = false;

                            //insert into PESSOA
                            queryError =  data.CommandSQL("insert into pessoa(cpf,senha, nome, idade, sexo, altura, peso) values('" + getCPF() + "','"+getSenha()+
                                "', '"+getNome()+"',"+getIdade()+ ",'" + getSexo() + "', " +
                                getAltura()+","+getPeso()+ ");");

                            //Inserto into DIA
                            queryError2 = data.CommandSQL("insert into dia (cafe_da_manha,almoco,janta,total_calorias,caloria_restante,tipo_atividade,duracao_atv,cpf,dieta_dia,atv_dia,dia) values ('Nada','Nada','Nada','"+getChanges+"','"+getChanges+"','Nenhuma','0','" + getCPF() + "', '" + selectDieta.SelectedItem.ToString() + "', '" + selectAtvFisica.SelectedItem.ToString() + "','1')");

                            if (!queryError)
                            {
                                MessageBox.Show("Houve um Erro Durante o Cadastro! Favor entrar em contato com Suporte", "Muito Obrigado!"
                                  , MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            
                            if (queryError && queryError2)
                            {
                                DieTop.Welcome_View welcome = new DieTop.Welcome_View();
                                this.Hide();
                                this.Closed += (s, args) => this.Close();
                                welcome.Show();
                                MessageBox.Show("Cadastro Efetuado! Favor, Fazer login para continuar", "Muito Obrigado!"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                           
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show(error.ToString());

                        }
                    }
                }
                else
                {
                    MessageBox.Show("As Senhas Estão Diferentes, Favor Refaze-las!","As Senhas Diferem!");
                    inputSenha.Text = "";
                    inputConfirmarSenha.Text = "";
                }
            }
            else
            {
                if(stop == false)
                {
                MessageBox.Show("Erro de Formulário, Favor Revisar!","Erro de Formulário!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }


        //Key press attributes
        private void inputNameKeyPress(object sender, KeyPressEventArgs e)
        {
            inputNome.Text = hook.AcceptOnlyLetters(e,getNome());
        }

        private void inputIdadeKeyPress(object sender, KeyPressEventArgs e)
        {
            inputIdade.Text = hook.AcceptOnlyNumbers(e,getIdade());
        }

        private void inputPesoKeyPress(object sender, KeyPressEventArgs e)
        {
           inputPeso.Text = hook.AcceptOnlyNumbers(e,getPeso());
        }

        private void inputAlturaKeyPress(object sender, KeyPressEventArgs e)
        {
           inputAltura.Text =  hook.AcceptOnlyNumbers(e,getAltura());
        }

      
    }
}
