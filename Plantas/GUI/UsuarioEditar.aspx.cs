using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Plantas.BO;
using System.Data;

namespace Plantas.GUI
{
    public partial class UsuarioEditar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void limpiar()
        {
            txtClave.Text = "";
            txtCorreoUsuario.Text = "";
            txtNombreUsuario.Text = "";
            txtContra.Text = "";
            txtTipoUsuario.Text = "";

        }
        public void cargaOperacion()
        {
            lblClave.Visible = false;
            txtClave.Visible = false;
            if ((String)Session["frmUsuarioOperacion"] == "Editar")
            {
                limpiar();
                buscar();
                lbtnNuevo.Visible = false;
            }
            else
            {
                limpiar();
                lbtnEliminar.Visible = false;
                lbtnModificar.Visible = false;
            }
        }
        public void buscar()
        {
            BO.Usuarios obj = (BO.Usuarios)Session["frmUsuarioBO"];
            Service.UsuarioCtrl objCtrl = new Service.UsuarioCtrl();
            DataTable dt = objCtrl.devuelveobj(obj);
            if (dt.Rows.Count != 0)
            {
                txtClave.Text = dt.Rows[0]["Id_usuario"].ToString();
                txtNombreUsuario.Text = dt.Rows[0]["Nombre"].ToString();
                txtCorreoUsuario.Text = dt.Rows[0]["Correo"].ToString();
                txtContra.Text = dt.Rows[0]["Contraseña"].ToString();
                txtTipoUsuario.Text = dt.Rows[0]["Id_tipo1"].ToString();

            }

        }
        public void eliminar()
        {
            BO.Usuarios obj = (BO.Usuarios)Session["frmUsuarioBO"];
            Service.UsuarioCtrl objCtrl = new Service.UsuarioCtrl();
            obj.Id_usuario = Convert.ToInt32(txtClave.Text.Trim());
            string mensaje = objCtrl.eliminarObj(obj);
            if (mensaje == "La operación se realizó de manera correcta")
            {
                Response.Redirect("WuSUARIOS.aspx");

            }
            else
            {
                Mensaje(mensaje);
            }

        }
        public void agregar()
        {
            string mensaje = "";
            if (txtNombreUsuario.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Nombre Usuario \n";
            }
            if (txtCorreoUsuario.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Correo Usuario \n";
            }
            if (txtTipoUsuario.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Tipo Usuario \n";
            }


            if (mensaje.Trim().Length == 0)
            {
                BO.Usuarios obj = new BO.Usuarios();
                Service.UsuarioCtrl objCtrl = new Service.UsuarioCtrl();
                obj.Nombre1 = txtNombreUsuario.Text.Trim().ToUpper();
                obj.Correo1 = txtCorreoUsuario.Text.Trim().ToUpper();
                obj.Contraseña1 = txtContra.Text.Trim().ToUpper();
                obj.Id_tipo1 = Convert.ToInt32(txtTipoUsuario.Text.Trim().ToUpper());


                string msn = objCtrl.creaObj(obj);
                if (msn == "La operación se realizó de manera correcta")
                {
                    Response.Redirect("WuSUARIOS.aspx");

                }
                else
                {
                    Mensaje(msn);
                }
            }
            else
            {
                Mensaje("Favor de ingresar los siguientes datos:\n" + mensaje);
            }
        }
        public void modificar()
        {
            string mensaje = "";
            if (txtClave.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce la Clave \n";
            }
            if (txtNombreUsuario.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Nombre Usuario \n";
            }
            if (txtCorreoUsuario.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Correo Usuario \n";
            }
            if (txtContra.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce la contraseña \n";
            }
            if (txtTipoUsuario.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Tipo Usuario \n";
            }

            if (mensaje.Trim().Length == 0)
            {
                BO.Usuarios obj = new BO.Usuarios();
                Service.UsuarioCtrl objCtrl = new Service.UsuarioCtrl();
                obj.Id_usuario = Convert.ToInt32(txtClave.Text.Trim().ToUpper());
                obj.Nombre1 = txtNombreUsuario.Text.Trim().ToUpper();
                obj.Correo1 = txtCorreoUsuario.Text.Trim().ToUpper();
                obj.Contraseña1 = txtContra.Text.Trim().ToUpper();
                obj.Id_tipo1 = Convert.ToInt32(txtTipoUsuario.Text.Trim().ToUpper());
                string msn = objCtrl.actualizaObj(obj);
                if (msn == "La operación se realizó de manera correcta" + 0)
                {
                    Response.Redirect("WuSUARIOS.aspx");

                }
                else
                {
                    Mensaje(msn);
                }
            }
            else
            {
                Mensaje("Favor de ingresar los siguientes datos:\n" + mensaje);
            }
        }
        private void Mensaje(string ex)
        {
            string mensaje = ex;
            mensaje = mensaje.Replace(Environment.NewLine, "\\n");
            mensaje = mensaje.Replace("\n", "\\n");
            mensaje = mensaje.Replace("'", "\"");
            ClientScript.RegisterClientScriptBlock(typeof(Page), "Error", "<script> alert('" + mensaje + "');</script>");
        }

        protected void lbtnNuevo_Click(object sender, EventArgs e)
        {
            agregar();
        }

        protected void lbtnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        protected void lbtnModificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        protected void lbtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Usuarios.aspx");
        }
    }
}