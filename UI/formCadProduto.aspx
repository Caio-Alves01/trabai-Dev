<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formCadProduto.aspx.cs" Inherits="trabai_Dev.UI.formCadProduto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Produto</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
</head>
<body>

    <nav>
        <div>
            <ul>
                <li>
                    <asp:HyperLink ID="HyperLinkInicial" NavigateUrl="~/UI/index.aspx" Text="Inicial" runat="server"></asp:HyperLink>
                </li>
                <li>
                    <asp:HyperLink ID="HyperLinkProdutos" NavigateUrl="~/UI/formTableProdutos.aspx" Text="Produtos" runat="server"></asp:HyperLink>
                </li>
                <li>
                    <asp:HyperLink ID="HyperLinkVoltar" NavigateUrl="~/UI/Home.aspx" Text="Principal" runat="server"></asp:HyperLink>
                </li>
            </ul>
        </div>
    </nav>
    <main>
        <form id="form1" runat="server">

            <div>
                <asp:HiddenField ID="id" runat="server" />

                <div>
                    <asp:Label for="nome" Text="Nome" runat="server"></asp:Label>
                    <asp:TextBox ID="nome" runat="server"></asp:TextBox>
                </div>

                <div>
                    <asp:Label for="descricao" Text="Descricao" runat="server"></asp:Label>
                    <asp:TextBox ID="descricao" TextMode="MultiLine" Columns="30" Rows="10" runat="server"></asp:TextBox>
                </div>

                <div>
                    <asp:Label for="valor" Text="Valor" runat="server"></asp:Label>
                    <asp:TextBox ID="valor" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label for="categoria" Text="Categoria" runat="server"></asp:Label>
                    <asp:DropDownList ID="categoria" runat="server"></asp:DropDownList>
                </div>
                <div>
                    <asp:Label for="fornecedor" Text="Fornecedor" runat="server"></asp:Label>
                    <asp:DropDownList ID="fornecedor" runat="server"></asp:DropDownList>
                </div>
                <div>
                    <asp:Label for="quatidade" Text="Quantidade" runat="server"></asp:Label>
                    <asp:TextBox ID="quantidade" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label for="imagem" Text="Imagem" runat="server"></asp:Label>
                    <asp:FileUpload ID="imagem" runat="server"></asp:FileUpload>
                </div>

                <div>
                    <asp:Button ID="salvar" runat="server" Text="Salvar" OnClick="Salvar_Click" />
                    <asp:Button ID="cancelar" runat="server" Text="Cancelar" OnClick="Cancelar_Click" />
                </div>
                <div class="form-group">
                    <asp:Label Text="" ID="msgOK" ForeColor="Green" Visible="false" class="col-sm-2 col-form-label" runat="server"></asp:Label>
                    <asp:Label Text="" ID="msgErro" ForeColor="Red" Visible="false" class="col-sm-2 col-form-label" runat="server"></asp:Label>
                    </div>

            </div>
            <div>
                <asp:GridView runat="server" ID="GridProdutos" class="table table-dark table-striped" OnRowDeleting="DeleteRow" OnRowCancelingEdit="CancelEditing" OnRowEditing="EditingRow" OnRowUpdating="UpdatingRow">
                    <Columns>
                    <asp:CommandField ShowDeleteButton="True" ButtonType="Link" runat="server" />
                    <asp:CommandField ButtonType="Link" ShowEditButton="True" UpdateText="Salvar" runat="server" />
                    </Columns>
                </asp:GridView>
            </div>
        </form>  
    </main>

    <footer>
      

    </footer>
</body>
</html>
