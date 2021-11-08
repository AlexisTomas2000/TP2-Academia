<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 640px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
  <div style="margin-left: auto; margin-right: auto; text-align: center; background-color: #E4E3E8;">
            
            <br />
            <br />
            
        <asp:Label ID="Label1" runat="server" Text="" Font-Bold="true" Font-Size="X-Large"
            CssClass="StrongText">Login</asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />

            <asp:Label runat="server" Text="Usuario"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtUsu" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="Contraseña" runat="server" Text="Contraseña"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtContra" runat="server" OnTextChanged="txtContra_TextChanged" TextMode="Password"></asp:TextBox>
            <br />

            <br />
            <br />

            <asp:Button ID="btnIngresar" runat="server" OnClick="btnIngresar_Click" Text="Ingresar" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="btnOlvideMiContra" runat="server" OnClick="btnOlvideMiContra_Click">Olvide mi contraseña</asp:LinkButton>

        </div>
    </form>
</body>
</html>
