<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UI.Web.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="Panel1" runat="server">  
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
        <asp:Label ID="Label1" runat="server" Text="" Font-Bold="true" Font-Size="X-Large"
            CssClass="StrongText"></asp:Label>
    </div>  
        </asp:Panel>
    <asp:Panel runat="server">
        <div style="margin-left: auto; margin-right: auto; text-align: center;">


            <br />
            <br />
            <br />
            <br />
            <br />


            <asp:LinkButton ID="btnEspecialidades" runat="server" Enabled="False" Visible="False" OnClick="btnEspecialidades_Click">Especialidades</asp:LinkButton>
            &nbsp;
            <asp:LinkButton ID="btnPlanes" runat="server" Enabled="False" Visible="False" OnClick="btnPlanes_Click">Planes</asp:LinkButton>  
            &nbsp;  
            <asp:LinkButton ID="btnComisiones" runat="server" Enabled="False" Visible="False">Comisiones</asp:LinkButton>


            <br />
            <br />
            <asp:LinkButton ID="btnCursos" runat="server" Enabled="False" Visible="False">Cursos</asp:LinkButton>
            &nbsp;
            <asp:LinkButton ID="btnUsuarios" runat="server" Enabled="False" Visible="False">Usuarios</asp:LinkButton>
            &nbsp;
            <asp:LinkButton ID="btnMaterias" runat="server" Enabled="False" Visible="False">Materias</asp:LinkButton>
            <br />
            <br />
            <asp:LinkButton ID="btnDocYCur" runat="server" Enabled="False" Visible="False">Docentes</asp:LinkButton>
            &nbsp;
            <asp:LinkButton ID="btnInscripciones" runat="server" Enabled="False" Visible="False">Inscripcion a cursado</asp:LinkButton>
            &nbsp;
            <asp:LinkButton ID="btnPersonas" runat="server" Enabled="False" Visible="False">Personas</asp:LinkButton>


            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />


        </div>  
        
        <div style="margin-left: auto; margin-right: auto; text-align: right;">
            <asp:LinkButton ID="btnSalir" runat="server" OnClick="btnSalir_Click">Salir</asp:LinkButton>
        </div>  

    </asp:Panel>
</asp:Content>
