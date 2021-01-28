using System;


namespace DieTop.Class
{
    class UserVar
    {

        public static string CPF_LOGIN { get; set; }
        public static string SENHA_LOGIN{ get; set; }
        public UserVar()
        {
            Populate();
            Connect();
            Cpf = CPF_LOGIN;
            Senha = SENHA_LOGIN;
        }

        

        db.Database data = new db.Database();
        Views.Dashboard dashboard;
     

        private void Populate()
        {
        }

        public string Cpf{ get; set; }
        public string Senha{ get; set; }
        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Sexo { get; set; }
        public string Peso { get; set; }
        public string Altura { get; set; }
        public string AtvSem { get; set; }
        public string Dieta { get; set; }



        private void Connect()
        {
           
            //data.CommandSelectSQL("select cpf,senha,nome from pessoa where cpf = '" + inputLogin.Text + "' and senha ='" + inputSenha.Text + "'");

        }
    }
}
