<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="UI.Web.UserControl.Login" %>
<asp:Panel ID="Panel1" runat="server" BackColor="#E4E3E8">
    <p>
        LOGIN</p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Usuario"></asp:Label>
        &nbsp;<asp:TextBox ID="txtUsu" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="usu" runat="server" ControlToValidate="txtUsu" ErrorMessage="El Usuario no puede ser vacío" ForeColor="Red">*</asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Contraseña"></asp:Label>
        &nbsp;<asp:TextBox ID="txtContra" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="contra" runat="server" ControlToValidate="txtContra" ErrorMessage="La Contraseña no puede ser vacía" ForeColor="Red">*</asp:RequiredFieldValidator>
    </p>
    <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:LinkButton ID="btnOC" runat="server" OnClick="btnOC_Click">Olvide mi contraseña</asp:LinkButton>
</asp:Panel>


