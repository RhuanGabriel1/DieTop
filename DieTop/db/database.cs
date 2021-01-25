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
                MessageBox.Show("Conexão com o Banco Falhou!!", "FAILED CONNECTION INTO DATABASE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Erro informado : " + e);
                connection.Close();
                Application.Exit();
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
                string data_source = "datasource=localhost;username=root;password=;database=testedb";
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
        }
        //public List<string> CommandSelectSQL(string sqlCommand ,int totalTables)
        //{
        //    //Insert Data into Database
        //    try
        //    {


        //        //List<string> list = new List<string>();
        //        Application.EnableVisualStyles();
        //        Application.SetCompatibleTextRenderingDefault(false);
        //        MySqlCommand command = new MySqlCommand(sqlCommand, connection);
        //        //list.Clear();
        //        MySqlDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {

        //            for(int i = 0; i<totalTables; i++)
        //            {
        //                string[] row = {
        //                    reader.GetString(i)

        //            };
                        
        //                //return row;
        //            }
                  
        //        }
        //        MessageBox.Show("Dados Inseridos com Sucesso!!", "Dados Inseridos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //        Console.WriteLine("Ação Realizada com Sucesso!");
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Houve um Erro!", e.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    List<string> teste = new List<string>();
        //    return teste;
        //}
        public void CloseConnection()
        {
            connection.Close();
        }

    }
}
