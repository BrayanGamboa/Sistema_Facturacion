using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Facturacion.Class.Objetos
{
    internal class Obj_Rol
    {
        public Obj_Rol() { }

        private string nombreRol;
        private int idRol;

        public string NombreRol { get => nombreRol; set => nombreRol = value; }
        public int IdRol { get => idRol; set => idRol = value; }

        public Obj_Rol(string nombreRol)
        {
            this.NombreRol = nombreRol;
        }


        public Obj_Rol(int idRol, string nombreRol)
        {
            this.NombreRol = nombreRol;
            this.IdRol = idRol;

        }
        public Obj_Rol(int idRol)
        {
            this.IdRol = idRol;

        }
    }
}
