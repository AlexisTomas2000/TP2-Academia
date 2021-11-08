<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UI.Web.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="Panel1" runat="server">  
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
        <asp:Label ID="Label1" runat="server" Text="" Font-Bold="true" Font-Size="X-Large"
            CssClass="StrongText"></asp:Label>
    </div>  
        </asp:Panel>
    <asp:Panel runat="server" BackColor="#CCCCCC">
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
            <asp:LinkButton ID="btnComisiones" runat="server" Enabled="False" Visible="False" OnClick="btnComisiones_Click">Comisiones</asp:LinkButton>


            <br />
            <br />
            <asp:LinkButton ID="btnCursos" runat="server" Enabled="False" Visible="False" OnClick="btnCursos_Click">Cursos</asp:LinkButton>
            &nbsp;
            <asp:LinkButton ID="btnUsuarios" runat="server" Enabled="False" Visible="False" OnClick="btnUsuarios_Click">Usuarios</asp:LinkButton>
            &nbsp;
            <asp:LinkButton ID="btnMaterias" runat="server" Enabled="False" Visible="False" OnClick="btnMaterias_Click">Materias</asp:LinkButton>
            <br />
            <br />
            <asp:LinkButton ID="btnDocYCur" runat="server" Enabled="False" Visible="False" OnClick="btnDocYCur_Click">Docentes</asp:LinkButton>
            &nbsp;
            <asp:LinkButton ID="btnInscripciones" runat="server" Enabled="False" Visible="False" OnClick="btnInscripciones_Click">Inscripcion a cursado</asp:LinkButton>
            &nbsp;
            <asp:LinkButton ID="btnPersonas" runat="server" Enabled="False" Visible="False" OnClick="btnPersonas_Click">Personas</asp:LinkButton>


            <br />
            <br />
            <asp:LinkButton ID="btnReportesCursos" runat="server" Enabled="False" OnClick="txtReportesCursos_Click" Visible="False">Reporte Curso</asp:LinkButton>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="btnReportesPlanes" runat="server" Enabled="False" OnClick="btnReportesPlanes_Click" Visible="False">Reporte Planes</asp:LinkButton>
            <br />
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" Height="168px" ImageUrl="~/Fotos/logo-utn (1) (1).png" Width="541px" />
            <br />
            <br />
            <br />


        </div>  
        
        <div style="margin-left: auto; margin-right: auto; text-align: right;">
            <asp:LinkButton ID="btnSalir" runat="server" OnClick="btnSalir_Click">Salir</asp:LinkButton>
        </div>  

    </asp:Panel>
</asp:Content>
