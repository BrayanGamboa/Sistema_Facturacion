using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Facturacion.Class.Objetos
{
    internal class Seguridad
    {
        private int idEmpleado, idSeguridad;
        private string nombreUsuario, contrasena, nombreUsuarioModifica, nombreEmpleado;

        public Seguridad() { }

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string NombreUsuarioModifica { get => nombreUsuarioModifica; set => nombreUsuarioModifica = value; }
        public int IdSeguridad { get => idSeguridad; set => idSeguridad = value; }
        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }

        public Seguridad(int idEmpleado, string nombreUsuario, string contrasena, string nombreUsuarioModifica)
        {
            this.IdEmpleado = idEmpleado;
            this.NombreUsuario = nombreUsuario;
            this.Contrasena = contrasena;
            this.NombreUsuarioModifica = nombreUsuarioModifica;
        }

        public Seguridad(string nombreEmpleado, string nombreUsuario, string contrasena, int idSeguridad)
        {            
            this.NombreUsuario = nombreUsuario;
            this.Contrasena = contrasena;
            this.NombreEmpleado = nombreEmpleado;
            this.IdSeguridad = idSeguridad;
        }

        public Seguridad(string nombreUsuario, string contrasena)
        {
            this.NombreUsuario = nombreUsuario;
            this.Contrasena = contrasena;
        }

        public Seguridad(int idEmpleado)
        {
            this.IdEmpleado = idEmpleado;
        }
    }
}
