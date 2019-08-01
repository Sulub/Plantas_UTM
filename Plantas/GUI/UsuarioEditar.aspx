<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Home.Master" AutoEventWireup="true" CodeBehind="UsuarioEditar.aspx.cs" Inherits="Plantas.GUI.UsuarioEditar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    Editar Usuario
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="barra-herramientas">
        <div class="btn-group">
          <asp:LinkButton ID="lbtnRegresar" runat="server" class="btn btn-primary" OnClick="lbtnRegresar_Click" >
              <span class="glyphicon glyphicon-refresh"></span>&nbsp;Regresar
          </asp:LinkButton>          
        </div>
        <div class="btn-group pull-right espacio">
          <asp:LinkButton ID="lbtnNuevo" runat="server" class="btn btn-primary" OnClick="lbtnNuevo_Click" Width="60px" >
              <span class="glyphicon glyphicon-refresh"></span>&nbsp;Agregar
          </asp:LinkButton>          
        </div>

        <div class="btn-group pull-right espacio">
         <asp:LinkButton ID="lbtnEliminar" runat="server" class="btn btn-primary" OnClick="lbtnEliminar_Click"  >
                   <span class="glyphicon glyphicon-print"></span>&nbsp;Eliminar
          </asp:LinkButton>        
        </div>
        <div class="btn-group pull-right espacio">
         <asp:LinkButton ID="lbtnModificar" runat="server" class="btn btn-primary" OnClick="lbtnModificar_Click" >
                   <span class="glyphicon glyphicon-search"></span>&nbsp;Modificar
          </asp:LinkButton>  
        </div>
</div>
    <br />
 <div class="col-md-12">
        <div class="col-md-6" >
            <div class="form-group">
                 <asp:Label ID="lblClave" runat="server" Text="Clave:"></asp:Label>
                 <asp:TextBox ID="txtClave" class="form-control" runat="server"></asp:TextBox>                    
             </div>
        </div>
        <div class="col-md-6" >
            <div class="form-group">
                 <asp:Label ID="lblNombreUsuario" runat="server" Text="Nombre Usuario:"></asp:Label>
                 <asp:TextBox ID="txtNombreUsuario" class="form-control" runat="server"></asp:TextBox>                    
            </div>
        </div> 
</div>
 <div class="col-md-12">
        <div class="col-md-6" >
            <div class="form-group">
                 <asp:Label ID="lblCorreoUsuario" runat="server" Text="Correo Usuario:"></asp:Label>
                 <asp:TextBox ID="txtCorreoUsuario" class="form-control" runat="server"></asp:TextBox>                    
             </div>
        </div>
        </div>
    <div class="col-md-12">
        <div class="col-md-6" >
            <div class="form-group">
                 <asp:Label ID="lblContra" runat="server" Text="Contraseña"></asp:Label>
                 <asp:TextBox ID="txtContra" class="form-control" runat="server"></asp:TextBox>                    
             </div>
        </div>
        </div>
 <div class="col-md-12">
        <div class="col-md-6" >
            <div class="form-group">
                 <asp:Label ID="lblTipoUsuario" runat="server" Text="Tipo Usuario:"></asp:Label>
                 <asp:TextBox ID="txtTipoUsuario" class="form-control" runat="server"></asp:TextBox>                    
             </div>
 </div>
 </div>
</asp:Content>
