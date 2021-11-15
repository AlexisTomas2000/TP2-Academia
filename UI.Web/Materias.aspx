<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Materias.aspx.cs" Inherits="UI.Web.Materias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="Panel1" runat="server" BackColor="#E4E3E8">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black" SelectedRowStyle-ForeColor="White"
            DataKeyNames="id_materia" BackColor="#E4E3E8" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnSelectedIndexChanged="gridView_SelectedIndexChanged" DataSourceID="SqlDataSource1" >
            <Columns>
                <asp:BoundField HeaderText="ID Materia" DataField="id_materia" InsertVisible="False" ReadOnly="True" SortExpression="id_materia" />
                <asp:BoundField HeaderText="Descripcion Materia" DataField="desc_materia" SortExpression="desc_materia" />
                <asp:BoundField HeaderText="Horas Semanales" DataField="hs_semanales" SortExpression="hs_semanales" />
                <asp:BoundField HeaderText="Horas Totales" DataField="hs_totales" SortExpression="hs_totales" />
                <asp:BoundField HeaderText="ID Plan" DataField="id_plan" SortExpression="id_plan" />
                <asp:BoundField DataField="desc_plan" HeaderText="Descripcion Plan" SortExpression="desc_plan" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />

            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:tp2_netConnectionString %>" SelectCommand="sp_ListaMaterias" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
    </asp:Panel>
<asp:Panel ID="formPanel" Visible="false" runat="server" BackColor="#E4E3E8">
        <asp:Label ID="idLabel" runat="server" Text="ID Materia: "></asp:Label>
        <asp:TextBox ID="idTextBox" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <asp:Label ID="descripcionLabel" runat="server" Text="Descripcion: "></asp:Label>
        <asp:TextBox ID="descripcionTextBox" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="descripcion" runat="server" ControlToValidate="descripcionTextBox"   
ErrorMessage="La descripcion no puede ser vacía" ForeColor="Red">*</asp:RequiredFieldValidator>  
        <br />
        <asp:Label ID="hsSemLabel" runat="server" Text="Horas Semanales "></asp:Label>
        <asp:TextBox ID="hsSemTextBox" runat="server" Width="136px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="hsSemTextBox"   
ErrorMessage="Las horas semalas no pueden ser vacías" ForeColor="Red">*</asp:RequiredFieldValidator> 
        <br />
         
        <asp:Label ID="hsTotLabel" runat="server" Text="Horas Totales: "></asp:Label>
        <asp:TextBox ID="hsTotTextBox" runat="server" Width="126px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="hsTotTextBox"   
ErrorMessage="Las horas Totales no pueden ser vacías" ForeColor="Red">*</asp:RequiredFieldValidator>  
        <br />

        <asp:Label ID="idPlanLabel" runat="server" Text="ID Plan: "></asp:Label>
        <asp:DropDownList ID="ddlPlan" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red"/> 
        <asp:Panel ID="formActionsPanel" runat="server">
        <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
            &nbsp;
            <asp:LinkButton ID="cancelarLinkButton" runat="server" CausesValidation="false" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
            <br />
    </asp:Panel>
    </asp:Panel>

    <asp:Panel ID="gridActionsPanel" runat="server" BackColor="#E4E3E8">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar </asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar </asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    </asp:Panel>
    <div style="margin-left: auto; margin-right: auto; text-align: right; background-color: #E4E3E8;">
       <asp:LinkButton ID="btnSalir" runat="server" OnClick="btnSalir_Click" >Salir</asp:LinkButton>
        </div>
</asp:Content>
