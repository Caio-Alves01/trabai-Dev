using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace trabai_Dev.DTO
{
    public class FornecedorDTO
    {
        private int id;
		private string nome, cnpj, email, telefone, nomeRepresentante, telefoneRepresentante;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cnpj {
            set
            {
                if (value != String.Empty)
                {
                    this.cnpj = value;
                }
                else
                {
                    throw new Exception("Cnpj Obrigatorio");
                }
            }
            get
            {
                return this.cnpj;
            }
        }
        public string Email {
            set 
            { 
                if (value != String.Empty)
                {
                    this.email = value;
                }
                else
                {
                    throw new Exception("Email Obrigatorio");
                }
            }
            get
            {
                return this.email;
            }
        }
        public string Telefone { get => telefone; set => telefone = value; }
        public string NomeRepresentante { get => nomeRepresentante; set => nomeRepresentante = value; }
        public string TelefoneRepresentante { get => telefoneRepresentante; set => telefoneRepresentante = value; }
    }
    
}