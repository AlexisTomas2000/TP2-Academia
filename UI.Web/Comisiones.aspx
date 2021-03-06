<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Comisiones.aspx.cs" Inherits="UI.Web.Comisiones" %>
<asp:Content ID="Content3" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="Panel3" runat="server" BackColor="#E4E3E8">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black" SelectedRowStyle-ForeColor="White"
            DataKeyNames="ID" BackColor="#E4E3E8" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnSelectedIndexChanged="gridView_SelectedIndexChanged" >
            <Columns>
              <asp:BoundField HeaderText="ID Comision" DataField="ID" />
                <asp:BoundField HeaderText="Descripcion Comision" DataField="Descripcion"  />
                <asp:BoundField HeaderText="Año Especialidad" DataField="AnioEspecialidad" />
                <asp:BoundField HeaderText="ID Plan" DataField="IdPlan"  />
                <asp:BoundField DataField="DescripcionP" HeaderText="Descripcion Plan" />
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
        <asp:Label ID="lbID" runat="server" Text="ID:"></asp:Label>
        <asp:TextBox ID="txtID" runat="server" ReadOnly="True"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtID"   
ErrorMessage="El ID no puede ser vacío" ForeColor="Red">*</asp:RequiredFieldValidator> 
        <br />
     <asp:Label ID="lbldesc" runat="server" Text="Descripcion: "></asp:Label>
        <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtDesc"   
ErrorMessage="La descripcion no puede ser vacía" ForeColor="Red">*</asp:RequiredFieldValidator>  
    <br />
        <asp:Label ID="lblAño" runat="server" Text="Año Especialidad:"></asp:Label>
        <asp:TextBox ID="txtAño" runat="server" Width="136px"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAño"   
ErrorMessage="El año no puede ser vacío" ForeColor="Red">*</asp:RequiredFieldValidator>  
    <br />
        <br />
        <asp:Label ID="lblIDEsp" runat="server" Text="ID Plan:"></asp:Label>
    <asp:DropDownList ID="ddlIdPlan" runat="server"></asp:DropDownList>
        <br />
      
        <asp:Panel ID="formActionsPanel" runat="server">
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red"/> 
            <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
            &nbsp;
            <asp:LinkButton ID="cancelarLinkButton" runat="server" CausesValidation="false" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
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