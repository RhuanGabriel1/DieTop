using System;
using System.Collections.Generic;

namespace DieTop.Class
{
    class UserVar
    {

        public static string CPF_LOGIN { get; set; }
        public static string SENHA_LOGIN{ get; set; }
        public UserVar()
        {
            Populate();
        }



        db.Database data = new db.Database();
        List<string> getData = new List<string>();
        private void Connect()
        {
           getData = data.CommandSelectSQL("select nome,cpf,idade,senha,sexo,altura,peso,fisica,dieta from pessoa where cpf = '" + CPF_LOGIN + "' and senha ='" + SENHA_LOGIN + "'");
        }

        private void Populate()
        {
            Connect();
            Nome = getData[0]; 
            Cpf = getData[1];
            Idade = getData[2];
            Senha = getData[3];
            Sexo = getData[4];
            Altura = getData[5];
            Peso = getData[6];
            AtvSem = getData[7];
            Dieta = getData[8]; 
        }

        public string Nome { get; set; }
        public string Cpf{ get; set; }
        public string Idade { get; set; }
        public string Senha{ get; set; }
        public string Sexo { get; set; }
        public string Altura { get; set; }
        public string Peso { get; set; }
        public string AtvSem { get; set; }
        public string Dieta { get; set; }



        
    }
}
