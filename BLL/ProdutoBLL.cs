using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using trabai_Dev.DTO;
using System.Web;
using trabai_Dev.DAL;

namespace trabai_Dev.BLL
{
    public class ProdutoBLL
    {
        private Conexao con = new Conexao();
        public void Insert(ProdutoDTO Produto)
        {
            string Sql = String.Format($@"insert into Produtos values(null,'{Produto.Nome}','{Produto.Valor}','{Produto.Descricao}','{Produto.FornecedorID}','{Produto.CategoriaID}','{Produto.QuantidadeEstoque}','{Produto.Foto}'); ");
            con.ExecutarComando(Sql);

        }
        public void Delete(ProdutoDTO Produto)
        {
            string Sql = String.Format($@"delete from Produtos where id ='{Produto.Id}'");
            con.ExecutarComando(Sql);
        }
        public void Update(ProdutoDTO Produto)
        {
            string Sql = String.Format($@"update Produtos set nome ='{Produto.Nome}',valor='{Produto.Valor}',descrição='{Produto.Descricao}',fornecedorID='{Produto.FornecedorID}',categoriaID='{Produto.CategoriaID}',quantidadeEstoque='{Produto.QuantidadeEstoque}',foto='{Produto.Foto}' where id='{Produto.Id}';");
            con.ExecutarComando(Sql);
        }
        public DataTable BuscarID(int ID) {
            string Sql = String.Format($@"select*from Produtos where id= '{ID}';");
            return con.ExecuteQuery(Sql);
        }
        public DataTable Pesquisar(string condicao)
        {
            string sql = string.Format($@"SELECT p.id , p.nome,  p.valor ,p.descrição, p.quantidadeEstoque, c.nome as categoria, f.nome as fornecedor, p.foto FROM Produtos p, Categoria c, Fornecedores f WHERE p.categoriaID = c.id and p.fornecedorID = f.id and " + condicao + " order by Id;");
            return con.ExecuteQuery(sql);
        }
        public DataTable BuscarTodos()
        {
            string sql = string.Format($@"select * from Produtos;");
            return con.ExecuteQuery(sql);
        }

    }
}