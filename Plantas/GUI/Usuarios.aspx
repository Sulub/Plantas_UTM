<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Home.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="Plantas.GUI.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    Usuarios
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <div class="row">
        <div class="col-lg-3">
<div class="btn-group">
      <asp:LinkButton ID="lbtnNuevo" runat="server" class="btn  btn-primary" OnClick="lbtnNuevo_Click"  >
          <span class="glyphicon glyphicon-new-window"></span>&nbsp;Nuevo   
      </asp:LinkButton>          
 </div>
  </div>
        <div class="col-lg-3">
<div class="btn-group fa-pull-right">
      <asp:LinkButton ID="lbtnImprimir" runat="server" class="btn  btn-primary"  >
          <span class="glyphicon glyphicon-print"></span>&nbsp;Imprimir
      </asp:LinkButton>          
 </div>
</div>
        <div class="col-lg-3">
<div class="btn-group pull-left espacio">
     <asp:LinkButton ID="lbtnBuscar" runat="server" class="btn btn-primary" OnClick="lbtnBuscar_Click" >
               <span class="glyphicon glyphicon-search"></span>&nbsp;Buscar
      </asp:LinkButton>
    </div>
</div>
        <div class="col-lg-3">
<div class="btn-group pull-left espacio">
     <asp:LinkButton ID="lbtnLimpiar" runat="server" class="btn btn-primary" >
               <span class="glyphicon glyphicon-refresh"></span>&nbsp;Limpiar
      </asp:LinkButton>  
    </div>
</div>

</div>
   
        
    <div class="row">
        <br />
        <asp:HiddenField ID="Id_Usuario" runat="server" Value="0" />
        <div class="row">
        <div class="col-lg-4">              
              <div class="form-group">
               <span >Nombre</span>
              <asp:TextBox ID="txtNombre_usuario" class="form-control"  runat="server"></asp:TextBox>
               </div>
        </div>
        <div class="col-lg-4">              
              <div class="form-group">
               <span >Correo</span>
              <asp:TextBox ID="txtCorreo_usuario" class="form-control"  runat="server"></asp:TextBox>
               </div>
        </div>
        <div class="col-lg-4">
              <div class="form-group">
               <span >tipo de usuario</span>
              <asp:TextBox ID="txtTipo" class="form-control" runat="server"></asp:TextBox>
               </div>
              
        </div>
        </div>
        <br />
        <asp:GridView ID="gvResultado" runat="server" class="table table-bordered" AutoGenerateColumns="False" DataKeyNames="Id_usuario" OnRowCommand="gvResultado_RowCommand" >
           
            <Columns>
                <asp:BoundField DataField="id_usuario" HeaderText="Codigo del usuario" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre del Usuario" />
                <asp:BoundField DataField="Correo" HeaderText="Correo" />
                <asp:BoundField DataField="Contraseña" HeaderText="Contraseña"/>
                  <asp:BoundField DataField="Id_tipo1" HeaderText="Tipo" />
               
                <asp:ButtonField ButtonType="Button" Text="Editar" CommandName="Editar" /> 
            </Columns>
           
            <EmptyDataTemplate>
                    No hay Datos Disponibles para Mostrar
            </EmptyDataTemplate> 
        </asp:GridView>
        <br />
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="2" RepeatDirection="Horizontal" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyField="IdFlor" GridLines="Horizontal" OnItemCommand="DataList1_ItemCommand" Width="80%" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
            <AlternatingItemStyle BackColor="#F7F7F7" />
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <ItemStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox1" class="form-control" runat="server" Text='<%# Eval("Nombre") %>'></asp:TextBox>
                <br />
                <asp:LinkButton ID="LinkButton1" class="btn btn-primary" runat="server" CommandName="Editar">Detalle</asp:LinkButton>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        </asp:DataList>
    </div>
</asp:Content>
