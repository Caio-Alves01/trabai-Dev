<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formLogin.aspx.cs" Inherits="trabai_Dev.UI.formLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Login</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
</head>
<body class="text-center">
    <form id="form1" class="form-signin" runat="server">
        <div class="form-group">
            <asp:Image ImageUrl="../sacola.png" AlternateText="Imagem não carregada" class="img-thumbnail" runat="server" />
            <h1 class="h3 mb-3 font-weight-normal">Acesso ao Sistema</h1>
        </div>
        <div class="form-group">
            <asp:Label for="txtEmail" Text="Email" runat="server"></asp:Label>
            <asp:TextBox type="email" ID="txtEmail" class="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label for="txtSenha" Text="Senha" runat="server"></asp:Label>
            <asp:TextBox type="password" ID="txtSenha" class="form-control" runat="server"></asp:TextBox>
        </div>
        <asp:Button Text="Entrar" ID="btnEntrar" class="btn btn-primary" runat="server" OnClick="BtnEntrar_Click" />
        <div>
            <asp:LinkButton Text="Cadastrar" ID="btnCadastrar" class="btn btn-link mb-4" runat="server" OnClick="BtnCadastrar_Click"></asp:LinkButton>

        </div>
        <div class="form-group">
            <asp:Label Text="" ID="msgOK" ForeColor="Green" Visible="false" class="col-sm-2 col-form-label" runat="server"></asp:Label>
            <asp:Label Text="" ID="msgErro" ForeColor="Red" Visible="false" class="col-sm-2 col-form-label" runat="server"></asp:Label>
        </div>
    </form>
    <footer>
     

    </footer>
</body>
</html>
