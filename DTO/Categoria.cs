using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace trabai_Dev.DTO
{
	public class Categoria
	{	
		private int id;
		private string nome, descricao;

		public int Id { get => id; set => id = value; }
		public string Nome { get => nome; set => nome = value; }
		public string Descricao { get => descricao; set => descricao = value; }
	}
}
