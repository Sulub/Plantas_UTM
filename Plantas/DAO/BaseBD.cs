using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Plantas.DAO
{
    public class BaseBD
    {
        private SqlConnection cnn;
        private SqlDataReader dr;
        private string stringConexion;
        private SqlCommand cmd = new SqlCommand();
        private SqlDataAdapter da;
        public BaseBD()
        {
            establecer_Conexion();
        }

        public SqlConnection Cnn { get => cnn; set => cnn = value; }
        public SqlDataReader Dr { get => dr; set => dr = value; }
        public SqlDataAdapter Da { get => da; set => da = value; }
        public SqlCommand Cmd { get => cmd; set => cmd = value; }

        private void establecer_Conexion()
        {

            stringConexion = "Data source=IRVING; initial catalog=Plantas_Medicinales; integrated security=true;";

            Cnn = new SqlConnection(stringConexion);

        }

        public void abrir_Conexion()
        {
            Cnn.Open();
        }
        public void cerrar_Conexion()
        {
            Cnn.Close();
        }

        public SqlDataAdapter execQuery(string query)
        {
            Da = new SqlDataAdapter();
            if (Cnn.State != System.Data.ConnectionState.Open)
            {
                abrir_Conexion();
                Cmd.Connection = Cnn;
                Cmd.CommandText = query;
                Da.SelectCommand = cmd;
                cerrar_Conexion();
                return Da;
            }
            else
            {
                //Cnn.Close();
                cerrar_Conexion();
                Da = null;
                return Da;
            }
        }
        public int execNonQuery(string query)
        {
            if (Cnn.State != System.Data.ConnectionState.Open)
            {
                abrir_Conexion();
                Cmd.Connection = Cnn;
                Cmd.CommandText = query;
                int i = Cmd.ExecuteNonQuery();
                if (i == 0)
                {
                    cerrar_Conexion();
                    return 0;
                }
                cerrar_Conexion();
                return 1;
            }
            else
            {
                //Cnn.Close();
                cerrar_Conexion();
                //Da = null;
                return 1;
            }
        }
    }
}