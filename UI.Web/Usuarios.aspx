<%@ Page Title="Usuarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
<asp:Panel ID="gridPanel" runat="server">
    <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="false">
        SelectedRowStyle-BackColor="Black"
        SelectedRowStyle-ForeColor="White"

</asp:Panel>
</asp:Content>
