using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Facturacion.Class.Objetos
{
    internal class Obj_Cliente
    {

       public Obj_Cliente() { }


        private int documento, idCliente;
        private string nombre, direccion, email, fechaIngreso, fechaRestiro, fechaModificacion, telefono;        
        

        
        private string nombreUsuario;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Documento { get => documento; set => documento = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public string FechaRestiro { get => fechaRestiro; set => fechaRestiro = value; }
        public string FechaModificacion { get => fechaModificacion; set => fechaModificacion = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }

        public Obj_Cliente(string nombre, int documento, string direccion, string telefono, string email, string nombreUsuario)
        {
            this.Nombre = nombre;
            this.Documento = documento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
            this.NombreUsuario = nombreUsuario;            
        }

        public Obj_Cliente(int idCliente, string nombre, int documento, string telefono)
        {
            this.IdCliente = idCliente;
            this.Nombre = nombre;
            this.Documento = documento;
            this.Telefono = telefono;            
        }

        public Obj_Cliente(string nombre, int documento, string telefono, string email)
        {            
            this.Nombre = nombre;
            this.Documento = documento;
            this.Telefono = telefono;
            this.Email = email;
        }

        public Obj_Cliente(int idCliente)
        {
            this.IdCliente = idCliente;
        }



    }
}
