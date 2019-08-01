using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Plantas.Service;
using System.Data;

namespace Plantas.GUI
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DoOpen();
        }
        public void DoOpen()
        {
            BO.Usuarios usuarios = new BO.Usuarios();
            Service.UsuarioCtrl usuario = new UsuarioCtrl();

            //el .length sirve para que cuente cuantos caracteres hay.
            if (txtNombre_usuario.Text.Trim().Length != 0)
            {
                usuarios.Nombre1 = txtNombre_usuario.Text.Trim();
            }
            if (txtCorreo_usuario.Text.Trim().Length != 0)
            {
                usuarios.Correo1 = txtCorreo_usuario.Text.Trim();
            }
            if (txtTipo.Text.Trim().Length != 0)
            {
                usuarios.Id_tipo1 = Convert.ToInt32(txtTipo.Text.Trim());
            }
            DataTable dt = usuario.devuelveobj(usuarios);
            gvResultado.DataSource = dt;
            gvResultado.DataBind();


        }

        protected void gvResultado_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                int indice = Convert.ToInt32(e.CommandArgument);
                int id = (int)gvResultado.DataKeys[indice].Value;
                BO.Usuarios obj = new BO.Usuarios();
                obj.Id_usuario = id;
                Session["frmUsuarioOperacion"] = "Editar";
                Session["frmUsuarioBO"] = obj;
                Response.Redirect("UsuarioEditar.aspx");
            }
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                int indice = Convert.ToInt32(e.Item.ItemIndex);
                int id = (int)DataList1.DataKeys[indice];
                BO.Usuarios obj = new BO.Usuarios();
                obj.Id_usuario = id;
                Session["frmFlorOperacion"] = "Editar";
                Session["frmFlorBO"] = obj;
                Response.Redirect("UsuarioEditar.aspx");
            }
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        protected void lbtnNuevo_Click(object sender, EventArgs e)
        {
            Session["frmFlorOperacion"] = "Nuevo";
            Response.Redirect("UsuarioEditar.aspx");
        }

        protected void lbtnBuscar_Click(object sender, EventArgs e)
        {
            DoOpen();
        }

      
    }
}