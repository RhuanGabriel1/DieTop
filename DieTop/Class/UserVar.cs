using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieTop.Class
{
    class UserVar
    {
        private string nome;
        private string cpf;
        private string idade;
        private string sexo;
        private string peso;
        private string altura;
        private string atvSem;
        private string dieta;
        private string senha;

        //Setting Attributes like a static method
        db.Database data = new db.Database();
        List<string> userData = new List<string>();
        List<string> userLogin = new List<string>();

        public List<string> returnLogin(string command)
        {
            userLogin = data.CommandSelectSQL(command);
            cpf = userLogin[0];
            senha = userLogin[1];
            nome = userLogin[2];

            return userLogin;
        }


        public List<string> SettingAttribuites()
        {
            //userData = data.CommandSelectSQL("select nome,cpf,idade,sexo,peso,altura,fisica,dieta pessoa where cpf = '" + userLogin[0]+ "' and senha ='" + userLogin[1]+ "'");
            nome = userData[0];
            cpf = userData[1];
            idade = userData[2];
            sexo = userData[3];
            peso = userData[4];
            altura = userData[5];
            atvSem = userData[6];
            dieta = userData[7];

            return userData;
        }



        //Get Attributes
        public string getNome()
        {
            return nome;
        }
         public string getIdade()
        {
            return idade;
        }
        public string getCPF()
        {
            return cpf;
        }

        public string getSexo()
        {
            return sexo;
        }
        public string getPeso()
        {
            return peso;
        }
        public string getAltura()
        {
            return altura;
        }
        public string getAtvSem()
        {
            return atvSem;
        }
        public string getDieta()
        {
            return dieta;
        }


    }
}
