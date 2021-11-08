<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OlvideMiContra.aspx.cs" Inherits="UI.Web.OlvideMiContra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Ingrese Email: "></asp:Label>
    <asp:TextBox ID="txtEmail" runat="server" OnTextChanged="txtEmail_TextChanged"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnEnviar" runat="server" OnClick="btnEnviar_Click1" Text="Enviar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:LinkButton ID="btnSalir" runat="server" OnClick="btnSalir_Click">Salir</asp:LinkButton>
</asp:Content>
