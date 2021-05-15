using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace trabai_Dev.DAL
{
    public class Conexao
    {
        private MySqlConnection conexao;
        private string conPar = "persist security info = false;" +
                                 "server = localhost;" +
                                 "database = banco;" +
                                 "user = root;" + "pwd = ;";

        public void Conectar() {
            try
            {
                conexao = new MySqlConnection(conPar);
                conexao.Open();
            }
            catch (MySqlException error) {

                throw new Exception("Erro de Conexâo " + error.Message);

            }
        }

        public void ExecutarComando(string Sql) {
            try
            {

                Conectar();
                MySqlCommand cmd = new MySqlCommand(Sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch(MySqlException error) {
                throw new Exception("Comando não executavel" + error.Message);
            }
        
        }

        public DataTable ExecuteQuery(string Sql) {
            try {
                Conectar();
                DataTable DT = new DataTable();
                MySqlDataAdapter Data = new MySqlDataAdapter(Sql, conexao);
                Data.Fill(DT);
                conexao.Close();
                return DT;
            }
            catch(MySqlException error){
                throw new Exception("Erro na pesquisa" + error.Message);
            }
        }

        
    }
}