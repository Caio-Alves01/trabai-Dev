using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using trabai_Dev.DAL;
using trabai_Dev.DTO;

namespace trabai_Dev.BLL
{
    public class CAtegoriaBLL
    {
        private Conexao con = new Conexao();
        public void Insert(CategoriaDTO Categoria)
        {
            string Sql = String.Format($@"insert into Categoria values(null,'{Categoria.Nome}','{Categoria.Descricao}';");
            con.ExecutarComando(Sql);

        }
        public void Delete(CategoriaDTO Categoria)
        {
            string Sql = String.Format($@"delete from Categoria where id ='{Categoria.Id}'");
            con.ExecutarComando(Sql);
        }
        public void Update(CategoriaDTO Categoria)
        {
            string Sql = String.Format($@"update Categoria set nome ='{Categoria.Nome}',descricao='{Categoria.Descricao}' where id= '{Categoria.Id}';");
            con.ExecutarComando(Sql);
        }
        public DataTable BuscarID(int ID)
        {
            string Sql = String.Format($@"select * from Categoria where id= '{ID}';");
            return con.ExecuteQuery(Sql);
        }
        public DataTable Pesquisar(string condicao)
        {
            string sql = string.Format($@"SELECT p.id , p.nome,  p.valor ,p.descricao, p.quantidadeEstoque, c.nome as categoria, f.nome as fornecedor, p.foto FROM produto p, categoria c, fornecedor f WHERE p.categoriaID = c.id and p.fornecedorID = f.id and " + condicao + " order by Id;");
            return con.ExecuteQuery(sql);
        }

        internal object BuscarTodos()
        {
            string sql = string.Format($@"select * from Categoria;");
            return con.ExecuteQuery(sql);
        }
    }
}