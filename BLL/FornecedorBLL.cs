using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using trabai_Dev.DTO;
using System.Web;
using trabai_Dev.DAL;

namespace trabai_Dev.BLL
{
    public class FornecedorBLL
    {
        private Conexao con = new Conexao();
        public void Insert(FornecedorDTO Fornecedor)
        {
            string Sql = String.Format($@"insert into Fornecedores values(null,'{Fornecedor.Nome}','{Fornecedor.Cnpj}','{Fornecedor.Email}','{Fornecedor.Telefone}','{Fornecedor.NomeRepresentante}','{Fornecedor.TelefoneRepresentante}'); ");
            con.ExecutarComando(Sql);

        }
        public void Delete(FornecedorDTO Fornecedor)
        {
            string Sql = String.Format($@"delete from Fornecedores where id ='{Fornecedor.Id}'");
            con.ExecutarComando(Sql);
        }
        public void Update(FornecedorDTO Fornecedor)
        {
            string Sql = String.Format($@"update Fornecedores set nome ='{Fornecedor.Nome}',valor='{Fornecedor.Cnpj}',descrição='{Fornecedor.Email}',fornecedorID='{Fornecedor.Telefone}',categoriaID='{Fornecedor.NomeRepresentante}',quantidadeEstoque='{Fornecedor.TelefoneRepresentante}' where id = '{Fornecedor.Id}';");

            con.ExecutarComando(Sql);
        }
        public DataTable BuscarID(int ID)
        {
            string Sql = String.Format($@"select*from Fornecedores where id= '{ID}';");
            return con.ExecuteQuery(Sql);
        }
        public DataTable Pesquisar(string condicao)
        {
            string sql = string.Format($@"SELECT p.id , p.nome,  p.valor ,p.descricao, p.quantidadeEstoque, c.nome as categoria, f.nome as fornecedor, p.foto FROM produto p, categoria c, fornecedor f WHERE p.categoriaID = c.id and p.fornecedorID = f.id and " + condicao + " order by Id;");
            return con.ExecuteQuery(sql);
        }

        internal object BuscarTodos()
        {
            string sql = string.Format($@"select * from Fornecedores;");
            return con.ExecuteQuery(sql);
        }
    }
}