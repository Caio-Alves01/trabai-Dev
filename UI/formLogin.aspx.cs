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
    public partial class formLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Instanciar o objeto ClienteDTO
                ClienteDTO clienteDTO = new ClienteDTO();
                clienteDTO.Email = txtEmail.Text;
                clienteDTO.Senha = txtSenha.Text;
                //Instanciar o objeto ClienteBLL
                ClienteBLL clienteBLL = new ClienteBLL();
                if (clienteBLL.Verificar(clienteDTO.Email, clienteDTO.Senha))
                {
                    Session["emailUsuario"] = clienteDTO.Email;
                    msgOK.Visible = true;
                    msgOK.Text = "Seja bem-vindo!";
                    Response.Redirect("Home.aspx");
                }
                else
                {
                   
                    msgErro.Visible = true;
                    msgErro.Text = "Cliente não encontrado!";

                }
            }
            catch (Exception ex)
            {
                msgErro.Visible = true;
                msgErro.Text = ex.Message;

            }
        }

        protected void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("formCadCliente.aspx");
        }

       
    }
}