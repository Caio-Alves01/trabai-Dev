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
    public partial class formCadProduto : System.Web.UI.Page
    {

        ProdutoDTO produtoDTO = new ProdutoDTO();
        ProdutoBLL produtoBLL = new ProdutoBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                this.Exibir();
            }
        }

        public void Exibir() {
            GridProdutos.DataSource = produtoBLL.BuscarTodos();
            GridProdutos.DataBind();
        }

        protected void Salvar_Click(object sender, EventArgs e)
        {
            try {
                produtoDTO.Nome = nome.Text;
                produtoDTO.Descricao = descricao.Text;
                produtoDTO.Valor = Convert.ToDouble(valor.Text);
                produtoDTO.CategoriaID = Convert.ToInt32(categoria.SelectedValue.ToString());
                produtoDTO.FornecedorID = Convert.ToInt32(fornecedor.SelectedValue.ToString());
                produtoDTO.QuantidadeEstoque = Convert.ToInt32(quantidade.Text);
                produtoDTO.Foto = imagem.FileName.ToString();
                produtoBLL.Insert(produtoDTO);
                string localFoto = Server.MapPath("/IMG/Produtos/" +produtoDTO.Foto);
                imagem.SaveAs(localFoto);

                string mensagem = "Produto inserido com sucesso!";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('" + mensagem + "')", true);
               
            }
            catch (Exception ex) {
                msgErro.Visible = true;
                msgErro.Text = ex.Message;
            }

        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            nome.Text = "";
            descricao.Text = "";
            categoria.SelectedIndex = -1;
            fornecedor.SelectedIndex = -1;
            valor.Text = "";
            descricao.Text = "";

        }

        protected void DeleteRow(object sender, GridViewDeleteEventArgs e)
        {
            produtoDTO.Id = Convert.ToInt32(e.Values[0]);
            produtoBLL.Delete(produtoDTO);
            Exibir();

        }

        protected void CancelEditing(object sender, GridViewCancelEditEventArgs e)
        {
            GridProdutos.EditIndex = -1;
            this.Exibir();
        }

        protected void EditingRow(object sender, GridViewEditEventArgs e)
        {
            GridProdutos.EditIndex = e.NewEditIndex;
            this.Exibir();
        }

        protected void UpdatingRow(object sender, GridViewUpdateEventArgs e)
        {
        try
            {
                produtoDTO.Id = int.Parse(e.NewValues[0].ToString());
                produtoDTO.Nome = e.NewValues[1].ToString();
                produtoDTO.Valor = double.Parse(e.NewValues[2].ToString());
                produtoDTO.Descricao = e.NewValues[3].ToString();
                produtoDTO.FornecedorID = int.Parse(e.NewValues[4].ToString());
                produtoDTO.CategoriaID = int.Parse(e.NewValues[5].ToString());
                produtoDTO.QuantidadeEstoque = int.Parse(e.NewValues[6].ToString());
                produtoBLL.Update(produtoDTO);
                GridProdutos.EditIndex = -1;
                this.Exibir();
            }
            catch (Exception ex)
            {
                Response.Write($"<script language=javascript>alert('{ex.Message}');</script>");
            }
        }
    }
}