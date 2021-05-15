<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormCadCategoria.aspx.cs" Inherits="trabai_Dev.UI.FormCadCategoria" %>

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
                    <asp:Label for="descricao" Text="Descrição" runat="server"></asp:Label>
                    <asp:TextBox ID="descricao" runat="server"></asp:TextBox>
                </div>

                <div>
                    <asp:Button ID="salvar" runat="server" Text="Salvar" OnClick="Salvar_Click" />
                    <asp:Button ID="cancelar" runat="server" Text="Cancelar" OnClick="Cancelar_Click" />
                </div>
                <div class="form-group">
                    <asp:Label Text="" ID="msgOK" ForeColor="Green" Visible="false" class="col-sm-2 col-form-label" runat="server"></asp:Label>
                    <asp:Label Text="" ID="msgErro" ForeColor="Red" Visible="false" class="col-sm-2 col-form-label" runat="server"></asp:Label>
                    </div>
                 
                <div>
                <asp:GridView runat="server" ID="GridCategoria" class="table table-dark table-striped" OnRowDeleting="DeleteRow" OnRowCancelingEdit="CancelEditing" OnRowEditing="EditingRow" OnRowUpdating="UpdatingRow">
                    <Columns>
                    <asp:CommandField ShowDeleteButton="True" ButtonType="Link" runat="server" />
                    <asp:CommandField ButtonType="Link" ShowEditButton="True" UpdateText="Salvar" runat="server" />
                    </Columns>
                </asp:GridView>
            
                </div>
            </div>

        </form>
 
</body>
</html>
