using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using trabai_Dev.DTO;
using trabai_Dev.BLL;

namespace trabai_Dev.UI
{
    public partial class FormCadFornecedor : System.Web.UI.Page
    {

        FornecedorDTO fornecedorDTO = new FornecedorDTO();
        FornecedorBLL fornecedorBLL = new FornecedorBLL();

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
                fornecedorDTO.Cnpj = cnpj.Text;
                fornecedorDTO.Email = email.Text;
                fornecedorDTO.Telefone = telefone.Text;
                fornecedorDTO.NomeRepresentante = nomeRepresentante.Text;
                fornecedorDTO.TelefoneRepresentante = telefoneRepresentante.Text;
                

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
            cnpj.Text = "";
            email.Text = "";
            telefone.Text = "";
            nomeRepresentante.Text = "";
            telefoneRepresentante.Text = "";

        }

        protected void DeleteRow(object sender, GridViewDeleteEventArgs e)
        {
            fornecedorDTO.Id = Convert.ToInt32(e.Values[0]);
            fornecedorBLL.Delete(fornecedorDTO);
            Exibir();

        }

        private void Exibir()
        {
            GridFornecedor.DataSource = fornecedorBLL.BuscarTodos();
            GridFornecedor.DataBind();
        }

        protected void CancelEditing(object sender, GridViewCancelEditEventArgs e)
        {
            GridFornecedor.EditIndex = -1;
            this.Exibir();
        }


        protected void EditingRow(object sender, GridViewEditEventArgs e)
        {
            GridFornecedor.EditIndex = e.NewEditIndex;
            this.Exibir();
        }

        protected void UpdatingRow(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                fornecedorDTO.Id = int.Parse(e.NewValues[0].ToString());
                fornecedorDTO.Nome = e.NewValues[1].ToString();
                fornecedorDTO.Cnpj = e.NewValues[2].ToString();
                fornecedorDTO.Email = e.NewValues[3].ToString();
                fornecedorDTO.Telefone = e.NewValues[4].ToString();
                fornecedorDTO.NomeRepresentante = e.NewValues[5].ToString();
                fornecedorDTO.TelefoneRepresentante = e.NewValues[6].ToString();
                fornecedorBLL.Update(fornecedorDTO);
                GridFornecedor.EditIndex = -1;
                this.Exibir();
            }
            catch (Exception ex)
            {
                Response.Write($"<script language=javascript>alert('{ex.Message}');</script>");
            }
        }
    }
    }
