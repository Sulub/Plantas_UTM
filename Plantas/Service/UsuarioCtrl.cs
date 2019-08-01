using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Plantas.DAO;
using System.Data.SqlClient;
using System.Data;

namespace Plantas.Service
{
    public class UsuarioCtrl
    {
        DAO.Uuarios objDAO;
        public UsuarioCtrl()
        {
            objDAO = new DAO.Uuarios();
        }
        public DataTable devuelveobj(object obj)
        {
            DataTable dt = new DataTable();
            dt = objDAO.devuelveDatos(obj);
            return dt;
        }
        public string creaObj(object obj)
        {
            int i = objDAO.crearUsuario(obj);
            if (i == 0)
                return "La operación se realizó de manera correcta";
            else
                return "La operación no pudo realizarse con éxito";
        }

        public string actualizaObj(object obj)
        {
            int i = objDAO.actualizaUSU(obj);
            if (i == 0)
                return "La operación se realizó de manera correcta" + i;
            else

                return "La operación no pudo realizarse con éxito ";
        }

        public string eliminarObj(object obj)
        {
            int i = objDAO.eliminarDatosUSU(obj);
            if (i == 0)
                return "La operación se realizó de manera correcta";
            else
                return "La operación no pudo realizarse con éxito";
        }

    }
}