using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Facturacion.Class.Objetos
{
    internal class Obj_Login
    {
        private string usuario, contrasena;
        private int idCredenciales, idEmpleado;

        public Obj_Login() { }

        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }

        public int IdCredenciales { get => idCredenciales; set => idCredenciales = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }

        public Obj_Login(string usuario, string contrasena)
        {
            this.Usuario = usuario;
            this.Contrasena = contrasena;
        }

        public Obj_Login(int idCredenciales, string usuario, string contrasena, int idEmpleado = 0)
        {
            this.IdCredenciales = idCredenciales;
            this.Usuario = usuario;
            this.Contrasena = contrasena;
            this.IdEmpleado = idEmpleado;
        }
    }
}
