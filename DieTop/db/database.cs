using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DieTop.db
{
    class Database
    {


        private MySqlConnection connection;
        string data_source = "datasource=localhost;username=root;password=;database=testedb";


        public void ConnectDB()
        {
            try
            {
                //Create a connect to mysql database
                //THIS DATASOURCE IS ONLY USED IN DEVELOPMENT, DONT USE THIS VARIABLE IN PRODUCTION 
                connection = new MySqlConnection(data_source);
                connection.Open();
                Console.WriteLine("Banco Conectado com Sucesso!");
               
            }catch(Exception e)
            {
                MessageBox.Show("Conexão com o Banco Falhou!!", "FAILED CONNECTION INTO DATABASE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            finally
            {
                CloseConnection();
            }
        }
        
        public void CommandSQL(string sqlCommand)
        {
            //Insert Data into Database
            try
            {
                connection = new MySqlConnection(data_source);
                connection.Open();
                MySqlCommand command = new MySqlCommand(sqlCommand, connection);
                command.ExecuteReader();
                MessageBox.Show("Dados Inseridos com Sucesso!!", "Dados Inseridos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Console.WriteLine("Ação Realizada com Sucesso!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Houve um Erro!  " +e.ToString(), e.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }
      
        public void CloseConnection()
        {
            connection.Close();
        }

        //TEST LIST FIELDS

        public void CommandSelectSQL(string sqlCommand, int totalTables)
        {
            //Insert Data into Database
            try
            {
                connection = new MySqlConnection(data_source);
                connection.Open();
                MySqlCommand command = new MySqlCommand(sqlCommand, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(0));
                    Console.WriteLine(reader.GetString(1));
                    Console.WriteLine(reader.GetString(2));
                    Console.WriteLine(reader.GetString(3));
                    Console.WriteLine(reader.GetString(4));
                    Console.WriteLine(reader.GetString(5));

                }
                //MessageBox.Show("Dados Inseridos com Sucesso!!", "Dados Inseridos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //Console.WriteLine("Ação Realizada com Sucesso!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Houve um Erro! "+e.ToString(), e.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }


    }
}
