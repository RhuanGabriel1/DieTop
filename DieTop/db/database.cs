using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DieTop.db
{
    class Database
    {


        private MySqlConnection connection;

        public void ConnectDB()
        {
            try
            {
                //Create a connect to mysql database
                //THIS DATASOURCE IS ONLY USED IN DEVELOPMENT, DONT USE THIS VARIABLE IN PRODUCTION 
                string data_source = "datasource=localhost;username=root;password=;database=testedb";
                connection = new MySqlConnection(data_source);
                connection.Open();
                Console.WriteLine("Banco Conectado com Sucesso!");
               
            }catch(Exception e)
            {
                Console.WriteLine("Erro informado : "+e);
                connection.Close();
            }
        }
        
        public void CommandSQL(string sqlCommand)
        {
            //Insert Data into Database
            try
            {
            MySqlCommand command = new MySqlCommand(sqlCommand, connection);
            command.ExecuteReader();
            Console.WriteLine("Ação Realizada com Sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro informado : " + e);
            }
        }


    }
}
