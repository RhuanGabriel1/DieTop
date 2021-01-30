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
        List<string> getDia = new List<string>();

        private void Connect()
        {
           getData = data.CommandSelectSQL("select nome,cpf,idade,senha,sexo,altura,peso from pessoa where cpf = '" + CPF_LOGIN + "' and senha ='" + SENHA_LOGIN + "';");
           getDia = data.CommandSelectSQL("select cafe_da_manha,almoco,janta,total_calorias,caloria_restante,tipo_atividade,duracao_atv,dieta_dia,atv_dia,dia from dia where cpf = '" + CPF_LOGIN + "';");
        
        
      

        public void Populate()
        {
            Connect();
            Nome = getData[0]; 
            Cpf = getData[1];
            Idade = getData[2];
            Senha = getData[3];
            Sexo = getData[4];
            Altura = getData[5];
            Peso = getData[6];

            //Day gets

            Cafe_da_manha = getDia[0];
            Almoco = getDia[1];
            Janta = getDia[2];
            Total_calorias = getDia[3];
            Caloria_restante = getDia[4];
            Tipo_atividade = getDia[5];
            Duracao_atv = getDia[6];
            Dieta = getDia[7];
            AtvSem = getDia[8];
            Dia = getDia[9];

        }
        //Dia
        public string Cafe_da_manha { get; set; }
        public string Almoco { get; set; }
        public string Janta { get; set; }
        public string Total_calorias { get; set; }
        public string Caloria_restante { get; set; }
        public string Tipo_atividade { get; set; }
        public string Duracao_atv { get; set; }
        public string Dieta { get; set; }

        public string AtvSem { get; set; }
        public string Dia { get; set; }
        //Pessoa
        public string Nome { get; set; }
        public string Cpf{ get; set; }
        public string Idade { get; set; }
        public string Senha{ get; set; }
        public string Sexo { get; set; }
        public string Altura { get; set; }
        public string Peso { get; set; }




        
    }
}
