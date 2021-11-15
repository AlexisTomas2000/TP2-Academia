<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Web.Login" %>
<%@ Register src="UserControl/Login.ascx" tagname="Login" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <uc1:Login ID="Login1" runat="server" />
</asp:Content>
