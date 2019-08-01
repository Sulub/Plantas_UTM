<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Home.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Plantas.GUI.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <a  class="navbar-brand js-scroll-trigger" href="#page-top">Iniciar Sesión</a>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="col-lg-12">
            <div class="row">
                <div class="col-lg-12"></div>
                <div class="col-lg-12">
                    
                    <br />
                    <br />
                   
                   <h1>Inicio de Sesión</h1>
                 
                    <div class="form-row">
                        <div class="form-group col-md-5">

                      
                            <br />
                            
                            
                            <asp:TextBox ID="txt_usu" placeholder="Usuario o Correo" CssClass="form-control" runat="server"></asp:TextBox>
                        
                    <br />
                           
                     
                    <asp:TextBox ID="txt_pass" type="password" placeholder="Password" CssClass="form-control" runat="server"></asp:TextBox>
                            <br />
                     <br />
                    
                            <asp:Label ID="Lab_Error" runat="server" Text="Label">Intentalo de Nuevo</asp:Label>
                            <br />
                            <br />
                   
                            <asp:Button ID="btnAceptar" runat="server" CssClass="btn-block btn-success" Text="Loggear" OnClick="btnAceptar_Click" />
              
                        </div>
                       <p></p>

                        
                       <div class="form-group col-md-2">
                           </div>

                       <div class="form-group col-md-5">
                        <img class="img-fluid rounded mb-5" src="../Recursos/estudiante%20(1).png" alt="">
                           </div>
                      </div>
                    </div>
                </div>
        
       
    </div>
</asp:Content>
