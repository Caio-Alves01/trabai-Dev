using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace trabai_Dev.DTO
{
    public class ClienteDTO
    {
        private int id;
        private string nome, cpf, endereco, telefone, email, senha;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
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
        public string Senha {
            set
            {
                if (value != String.Empty)
                {
                    this.senha = value;
                }
                else
                {
                    throw new Exception("Senha Obrigatorio");
                }
            }
            get
            {
                return this.senha;
            }
        }
    }
}