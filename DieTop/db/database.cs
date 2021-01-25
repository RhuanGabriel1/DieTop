using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DieTop.db
{
    class Database
    {


        MySqlConnection connection;

        public void ConnectDB()
        {
            try
            {
                //Create a connect to mysql database
                string data_source = "datasource=localhost;username=root;password=;database=testedb";
                connection = new MySqlConnection(data_source);

                //Insert Data to test
                string insertData = "insert into alimento(nome_alim, tipo_alim, calorias_alim) values('Rola','Pênis',1000);";
                MySqlCommand command = new MySqlCommand(insertData,connection);

                connection.Open();
                command.ExecuteReader();
                Console.WriteLine("INSERT OK!");
            }catch(Exception e)
            {
                Console.WriteLine("Deu Bosta");
                Console.WriteLine(e);

            }
            finally
            {
                connection.Close();
            }
        }


        //private MySqlConnection mConn;
        //private MySqlDataAdapter mAdapter;
        //private DataSet mDataSet;

    


        //public void mostraResultados()
        //{
        //    mDataSet = new DataSet();
        //    mConn = new MySqlConnection("Persist Security Info=False; server=127.0.0.1;database=testedb;uid=root");
        //    mConn.Open();

        //    //cria um adapter utilizando a instrução SQL para aceder à tabela
        //    mAdapter = new MySqlDataAdapter("insert into alimento(nome_alim, tipo_alim, calorias_alim) values('Rola','Pênis',1000);", mConn);

        //    //preenche o dataset através do adapter
        //    //mAdapter.Fill(mDataSet, "tabela_dados");

         
        //}
       






        //public void StartBd()
        //{
        //    MySqlConnection conexao = new MySqlConnection("server=127.0.0.1;User Id=root;database=testedb; password=");
        //    //DataTable tabela = new DataTable();
        //    try
        //    {
        //        conexao.Open();
        //        Console.WriteLine("Banco Conectado com Sucesso!");
        //    }
        //    catch(Exception e)
        //    {
        //        conexao.Close();
        //        Console.WriteLine("Erro Na Conexão com o Banco!");
        //        Console.WriteLine(e);

        //    }



        //    try
        //    {
        //        MySqlCommand comando = new MySqlCommand("insert into alimento(nome_alim, tipo_alim, calorias_alim) values('Rola','Pênis',1000);", conexao);
        //        Console.WriteLine("UPDATE FEITO COM SUCESSO");
        //    }catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //    }
        //}

    }
}
