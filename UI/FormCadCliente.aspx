<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormCadCliente.aspx.cs" Inherits="trabai_Dev.UI.FormCadCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <main>
        <form id="form1" runat="server">

            <div>
                <asp:HiddenField ID="id" runat="server" />

                <div>
                    <asp:Label for="nome" Text="Nome" runat="server"></asp:Label>
                    <asp:TextBox ID="nome" runat="server"></asp:TextBox>
                </div>

                <div>
                    <asp:Label for="cpf" Text="CPF" runat="server"></asp:Label>
                    <asp:TextBox ID="cpf" runat="server"></asp:TextBox>
                </div>

                <div>
                    <asp:Label for="endereco" Text="Endereço" runat="server"></asp:Label>
                    <asp:TextBox ID="endereco" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label for="telefone" Text="Telefone" runat="server"></asp:Label>
                    <asp:TextBox ID="telefone" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label for="email" Text="Email" runat="server"></asp:Label>
                    <asp:TextBox ID="email" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label for="senha" Text="Senha" runat="server"></asp:Label>
                    <asp:TextBox ID="senha" runat="server"></asp:TextBox>
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

        </form>
    </main>

    <footer>
      

    </footer>
</body>
</html>
