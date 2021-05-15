using trabai_Dev.BLL;
using trabai_Dev.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace trabai_Dev.UI
{
    public partial class FormCadCliente : System.Web.UI.Page
    {
        ClienteDTO clienteDTO = new ClienteDTO();
        ClienteBLL clienteBLL = new ClienteBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Salvar_Click(object sender, EventArgs e)
        {
            try{
                clienteDTO.Cpf = cpf.Text;
                clienteDTO.Endereco = endereco.Text;
                clienteDTO.Telefone = telefone.Text;
                clienteDTO.Email = email.Text;
                clienteDTO.Senha = senha.Text;
                clienteBLL.Insert(clienteDTO);
                Response.Redirect("formLogin.aspx");
            }
            catch(Exception ex){
                msgErro.Visible = true;
                msgErro.Text = ex.Message;
            }

        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("formLogin.aspx");
        }
    }
}