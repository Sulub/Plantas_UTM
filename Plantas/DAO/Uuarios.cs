using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Plantas.DAO
{
    public class Uuarios
    {
        string sql;
        BaseBD bd;
        public Uuarios() { }

        public DataTable devuelveDatos(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            BO.Usuarios data = (BO.Usuarios)obj;
            bd = new BaseBD();
            DataTable dt = new DataTable();
            if (data.Id_usuario > 0)
            {
                cadenaWhere = cadenaWhere + " Id_usuario=@Id_Usuario and";
                bd.Cmd.Parameters.Add("@Id_usuario", SqlDbType.Int);
                bd.Cmd.Parameters["@Id_usuario"].Value = data.Id_usuario;
                edo = true;
            }
            if (data.Nombre1 != null)
            {
                cadenaWhere = cadenaWhere + " Nombre=@Nombre and";
                bd.Cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
                bd.Cmd.Parameters["@Nombre"].Value = data.Nombre1;
                edo = true;
            }
            if (data.Correo1 != null)
            {
                cadenaWhere = cadenaWhere + " Correo=@Correo and";
                bd.Cmd.Parameters.Add("@Correo", SqlDbType.VarChar);
                bd.Cmd.Parameters["@Correo"].Value = data.Correo1;
                edo = true;
            }
            if (data.Id_tipo1 > 0)
            {
                cadenaWhere = cadenaWhere + " Id_tipo1=@Id_tipo1 and";
                bd.Cmd.Parameters.Add("@Id_tipo1", SqlDbType.Int);
                bd.Cmd.Parameters["@Id_tipo1"].Value = data.Id_usuario;
                edo = true;
            }
            if (data.Id_libro1 > 0)
            {
                cadenaWhere = cadenaWhere + "Id_libro1=@Id_libro1 and";
                bd.Cmd.Parameters.Add("@Id_libro1", SqlDbType.Int);
                bd.Cmd.Parameters["@Id_libro1"].Value = data.Id_libro1;
            }
            if (edo == true)
            {
                cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }
            sql = " SELECT * FROM usuario " + cadenaWhere;
            bd.execQuery(sql).Fill(dt);
            return dt;

        }

        public int crearUsuario(object obj)
        {
            BO.Usuarios data = (BO.Usuarios)obj;
            bd = new BaseBD();
            sql = "INSERT INTO usuario VALUES(@Nombre1,@Correo,@Contraseña,@id_tipo1,@Id_libro1)";

            bd.Cmd.Parameters.Add("@Nombre1", SqlDbType.VarChar);
            bd.Cmd.Parameters.Add("@Correo", SqlDbType.VarChar);
            bd.Cmd.Parameters.Add("@Contraseña", SqlDbType.VarChar);
            bd.Cmd.Parameters.Add("@Id_tipo1", SqlDbType.VarChar);
            bd.Cmd.Parameters.Add("@Id_libro1", SqlDbType.VarChar);
            int i = bd.execNonQuery(sql);
            if (i == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int eliminarDatosUSU(object obj)
        {
            BO.Usuarios data = (BO.Usuarios)obj;
            bd = new BaseBD();
            sql = "DELETE FROM USUARIO WHERE id_usuario=@Id_usuario";

            bd.Cmd.Parameters.Add("@Id_usuario", SqlDbType.Int);

            bd.Cmd.Parameters["@Id_usuario"].Value = data.Id_usuario;


            int i = bd.execNonQuery(sql);
            if (i == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int actualizaUSU(object obj)
        {
            BO.Usuarios data = (BO.Usuarios)obj;
            bd = new BaseBD();
            sql = "UPDATE usuario SET Nombre=@Nombre1,Correo=@Correo,Contraseña=@Contraseña,Id_tipo1=@Id_tipo1,Id_libro1=Id_libro1 WHERE Id_usuario=@Id_usuario ";

            bd.Cmd.Parameters.Add("@Id_usuario", SqlDbType.Int);
            bd.Cmd.Parameters.Add("@Nombre1", SqlDbType.VarChar);
            bd.Cmd.Parameters.Add("@Correo", SqlDbType.VarChar);
            bd.Cmd.Parameters.Add("@Contraseña", SqlDbType.VarChar);
            bd.Cmd.Parameters.Add("@Id_tipo1", SqlDbType.Int);
            bd.Cmd.Parameters.Add("@Id_libro1", SqlDbType.Int);

            bd.Cmd.Parameters["@Id_usuario"].Value = data.Id_usuario;
            bd.Cmd.Parameters["@Nombre1"].Value = data.Nombre1;
            bd.Cmd.Parameters["@Correo"].Value = data.Correo1;
            bd.Cmd.Parameters["@Contraseña"].Value = data.Contraseña1;
            bd.Cmd.Parameters["@Id_tipo1"].Value = data.Id_tipo1;
            bd.Cmd.Parameters["@Id_libro1"].Value = data.Id_libro1;



            int i = bd.execNonQuery(sql);
            if (i == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }


        public DataTable ValidarUsuario(object obj)
        {
            BO.Usuarios data = (BO.Usuarios)obj;
            bd = new BaseBD();
            DataTable dt = new DataTable();

            sql = "SELECT * FROM usuario WHERE Contraseña=@Contraseña AND Nombre=(SELECT Nombre FROM usuario WHERE Nombre=@Nombre1 OR Correo=@Correo) ";

            bd.Cmd.Parameters.Add("@Correo", SqlDbType.VarChar);
            bd.Cmd.Parameters["@Correo"].Value = data.Correo1;
            bd.Cmd.Parameters.Add("@Nombre1", SqlDbType.VarChar);
            bd.Cmd.Parameters["@Nombre1"].Value = data.Nombre1;
            bd.Cmd.Parameters.Add("@Contraseña", SqlDbType.VarChar);
            bd.Cmd.Parameters["@Contraseña"].Value = data.Contraseña1;

            bd.execQuery(sql).Fill(dt);

            return dt;
        }
    }
}