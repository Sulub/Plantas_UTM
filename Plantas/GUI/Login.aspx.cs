using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Plantas.DAO;
using Plantas.BO;
using System.Data;
using System.Data.SqlClient;

namespace Plantas.GUI
{
    public partial class Login : System.Web.UI.Page
    {
        BO.Usuarios bo = new BO.Usuarios();
        DAO.Uuarios dao = new DAO.Uuarios();

        protected void Page_Load(object sender, EventArgs e)
        {
            Lab_Error.Visible = false;
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            bo.Nombre1 = txt_usu.Text;
            bo.Correo1 = txt_usu.Text;
            bo.Contraseña1 = txt_pass.Text;
            DataTable dato = dao.ValidarUsuario(bo);
            if (dato.Rows.Count >= 1)
            {
                DataRow fila = dato.Rows[0];

                Datoslogin.Id_usuario = Convert.ToInt32(fila["id_usuario"]);
                Datoslogin.Nombre = fila["Nombre"].ToString();
                Datoslogin.Correo = fila["Correo"].ToString();
                Datoslogin.id_tipo1 = Convert.ToInt32(fila["id_tipo1"]);
                Response.Redirect("Pagina_Prncipal.aspx");  
            }
            else
            {
                Lab_Error.Visible = true;
            }

            
        }
    }
}