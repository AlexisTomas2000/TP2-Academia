<%@ Page Title="Planes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Planes.aspx.cs" Inherits="UI.Web.Plan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
       <asp:Panel ID="Panel1" runat="server" BackColor="#E4E3E8">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black" SelectedRowStyle-ForeColor="White"
            DataKeyNames="ID" BackColor="#E4E3E8" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnSelectedIndexChanged="gridView_SelectedIndexChanged" >
            <Columns>
                <asp:BoundField HeaderText="ID Plan" DataField="ID"/>
                <asp:BoundField HeaderText="Descripcion Plan" DataField="Descripcion"  />
                <asp:BoundField HeaderText="ID Especialidad" DataField="IDEspecialidad" />
                <asp:BoundField DataField="DescripcionE" HeaderText="Descripcion Especialidad"  />
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
    </asp:Panel>
<asp:Panel ID="formPanel" Visible="false" runat="server" BackColor="#E4E3E8">
        <asp:Label ID="IDLabel" runat="server" Text="ID: "></asp:Label>
        <asp:TextBox ID="IDTextBox" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <asp:Label ID="DescripcionLabel" runat="server" Text="Descripcion: "></asp:Label>
        <asp:TextBox ID="DescripcionTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="Descripcion" runat="server" ControlToValidate="DescripcionTextBox"   
ErrorMessage="La descripcion no puede ser vacía" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="IDEspLabel" runat="server" Text="ID Especialidad: "></asp:Label>
         <asp:DropDownList ID="ddlIDEsp" runat="server"></asp:DropDownList>
        <br />
        
        <asp:Panel ID="formActionsPanel" runat="server">
             <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red"/> 
        <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
            <br />
    </asp:Panel>
    </asp:Panel>

    <asp:Panel ID="gridActionsPanel" runat="server" BackColor="#E4E3E8">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar </asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar </asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    </asp:Panel>
                <div style="margin-left: auto; margin-right: auto; text-align: right; background-color: #E4E3E8;">
            <asp:LinkButton ID="btnSalir" runat="server" Text="Salir" OnClick="salirClick"></asp:LinkButton>
        </div>  
</asp:Content>