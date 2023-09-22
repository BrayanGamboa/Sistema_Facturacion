using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Facturacion.Class.Objetos
{
    internal class Empleado
    {


        public Empleado() { }

        private string nombre, direccion, email, datosAdicionales, nombreRol, telefono;
        private int documento, idRolEmpleado, idEmpleado;


        public string Nombre { get => nombre; set => nombre = value; }
        public int Documento { get => documento; set => documento = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int IdRolEmpleado { get => idRolEmpleado; set => idRolEmpleado = value; }
        public string Email { get => email; set => email = value; }
        public string DatosAdicionales { get => datosAdicionales; set => datosAdicionales = value; }
        public string NombreRol { get => nombreRol; set => nombreRol = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }

        public Empleado(string nombre, int documento, string direccion, string telefono, int idRolEmpleado, string email, string datosAdicionales)
        {
            this.Nombre = nombre;
            this.Documento = documento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.IdRolEmpleado = idRolEmpleado;
            this.Email = email;
            this.DatosAdicionales = datosAdicionales;            
        }

        public Empleado(int idEmpleado, string nombre, int documento, string telefono)
        {
            this.IdEmpleado = idEmpleado;
            this.Nombre = nombre;
            this.Documento = documento;
            this.Telefono = telefono;
        }

        public Empleado(int idEmpleado) {
            this.IdEmpleado = idEmpleado;
        }

        public Empleado(string nombre)
        {
            this.Nombre = nombre;
        }
    }

}
