<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="trabai_Dev.UI.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>

    <nav>
        <div>
            <ul>
                <li>
                    <asp:HyperLink ID="HyperLinkProdutos" NavigateUrl="~/UI/formCadProduto.aspx" Text="Produtos" runat="server"></asp:HyperLink>
                </li>
                <li>
                    <asp:HyperLink ID="HyperLinkFornecedores" NavigateUrl="~/UI/FormCadFornecedor.aspx" Text="Fornecedores" runat="server"></asp:HyperLink>
                </li>
                <li>
                    <asp:HyperLink ID="HyperLinkCategoria" NavigateUrl="~/UI/FormCadCategoria.aspx" Text="Categorias" runat="server"></asp:HyperLink>
                </li>
            </ul>
        </div>
    </nav>

    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
