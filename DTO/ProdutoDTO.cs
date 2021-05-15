using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace trabai_Dev.DTO
{
    public class ProdutoDTO
    {
        private int id, quantidadeEstoque, categoriaID, fornecedorID;
        private string nome, descricao, foto;
        private double valor;

        public int Id { get => id; set => id = value; }

        public int FornecedorID { get => fornecedorID; set => fornecedorID = value; }

        public string Foto { get => foto; set => foto = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Nome {
            set
            {
                if (value != String.Empty) {
                    this.nome = value;
                }
                else {
                    throw new Exception("Nome Obrigatorio");
                }
            }
            get {
                return this.nome;
            }
                
        }
        public string Descricao
        {
            set
            {
                if (value != String.Empty)
                {
                    this.descricao = value;
                }
                else
                {
                    throw new Exception("Descricao Obrigatorio");
                }
            }
            get
            {
                return this.descricao;
            }
          }

            public int QuantidadeEstoque
        {
            set
            {
                if (value >= 0)
                {
                    this.quantidadeEstoque = value;
                }
                else
                {
                    throw new Exception("Quantidade de estoque Obrigatorio");
                }
            }
            get
            {
                return this.quantidadeEstoque;
            }
        }
        public int CategoriaID
        {
            set
            {
                if (value >= 0)
                {
                    this.categoriaID = value;
                }
                else
                {
                    throw new Exception("Quantidade de estoque Obrigatorio");
                }
            }
            get
            {
                return this.categoriaID;
            }
        }
    }
    
}