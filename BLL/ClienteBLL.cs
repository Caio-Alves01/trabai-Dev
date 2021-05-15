using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using trabai_Dev.DAL;
using trabai_Dev.DTO;

namespace trabai_Dev.BLL
{
    public class ClienteBLL
    {


        private Conexao con = new Conexao();

        public void Insert(ClienteDTO Cliente)
        {
            string Sql = String.Format($@"insert into Clientes values(null,'{Cliente.Nome}','{Cliente.Cpf}','{Cliente.Endereco}','{Cliente.Telefone}','{Cliente.Email}','{Cliente.Senha}');");
            con.ExecutarComando(Sql);
        }

        public Boolean Verificar(string Email, string Senha)
        {
            string Sql = String.Format($@"Select * from Clientes where email = '{Email}' and senha = '{Senha}';");
            DataTable DT = con.ExecuteQuery(Sql);
            return (DT.Rows.Count == 1 ? true : false);

        }
    } 
}