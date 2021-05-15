using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using trabai_Dev.BLL;
using trabai_Dev.DTO;

namespace trabai_Dev.UI
{
    public partial class FormCadCategoria : System.Web.UI.Page
    {
        CategoriaDTO fornecedorDTO = new CategoriaDTO();
        CAtegoriaBLL fornecedorBLL = new CAtegoriaBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                this.Exibir();
            }
        }

        protected void Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                fornecedorDTO.Nome = nome.Text;
                fornecedorDTO.Descricao = descricao.Text;
           


                string mensagem = "Produto inserido com sucesso!";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('" + mensagem + "')", true);

            }
            catch (Exception ex)
            {
                msgErro.Visible = true;
                msgErro.Text = ex.Message;
            }
        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            nome.Text = "";
            descricao.Text = "";

        }

        protected void DeleteRow(object sender, GridViewDeleteEventArgs e)
        {
            fornecedorDTO.Id = Convert.ToInt32(e.Values[0]);
            fornecedorBLL.Delete(fornecedorDTO);
            Exibir();

        }

        private void Exibir()
        {
            GridCategoria.DataSource = fornecedorBLL.BuscarTodos();
            GridCategoria.DataBind();
        }

        protected void CancelEditing(object sender, GridViewCancelEditEventArgs e)
        {
            GridCategoria.EditIndex = -1;
            this.Exibir();
        }


        protected void EditingRow(object sender, GridViewEditEventArgs e)
        {
            GridCategoria.EditIndex = e.NewEditIndex;
            this.Exibir();
        }

        protected void UpdatingRow(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                fornecedorDTO.Id = int.Parse(e.NewValues[0].ToString());
                fornecedorDTO.Nome = e.NewValues[1].ToString();
                fornecedorDTO.Descricao = e.NewValues[2].ToString();
                fornecedorBLL.Update(fornecedorDTO);
                GridCategoria.EditIndex = -1;
                this.Exibir();
            }
            catch (Exception ex)
            {
                Response.Write($"<script language=javascript>alert('{ex.Message}');</script>");
            }
        }
    }
}