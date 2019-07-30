using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Plantas.BO
{
    public class Usuarios
    {
        int id_usuario;
        string Nombre;
        string Correo;
        string Contraseña;
        int id_tipo1;
        int id_libro1;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Correo1 { get => Correo; set => Correo = value; }
        public string Contraseña1 { get => Contraseña; set => Contraseña = value; }
        public int Id_tipo1 { get => id_tipo1; set => id_tipo1 = value; }
        public int Id_libro1 { get => id_libro1; set => id_libro1 = value; }
    }
}