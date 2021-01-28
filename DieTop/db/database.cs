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
            bool error = false;
            //Insert Data into Database
            try
            {
                connection = new MySqlConnection(data_source);
                connection.Open();
                MySqlCommand command = new MySqlCommand(sqlCommand, connection);
                command.ExecuteReader();
                
               
            }
            catch (Exception e)
            {
                error = true;
            }
            finally
            {
                if(error == false)
                {
                    MessageBox.Show("Dados Inseridos com Sucesso!!", "Dados Inseridos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Houve um Erro na Inserção de Dados!", "Houve um Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                CloseConnection();
            }
        }
      
        public void CloseConnection()
        {
            connection.Close();
        }

        //TEST LIST FIELDS

        public List<string> CommandSelectSQL(string sqlCommand)
        {
            //Create a list for return
            List<string> getData = new List<string>();


            //Get Data into Database
            try
            {
              
                connection = new MySqlConnection(data_source);
                connection.Open();
                MySqlCommand command = new MySqlCommand(sqlCommand, connection);
                MySqlDataReader reader = command.ExecuteReader();
                int total = reader.VisibleFieldCount;
                while (reader.Read())
                {
                    for (int i = 0; i < total; i++)
                    {
                        getData.Add(reader.GetValue(i).ToString());

                    }
                }
       
            }
            catch (Exception e)
            {
                MessageBox.Show("Houve um Erro! "+e.ToString(), e.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
            return getData;
        }


    }
}
