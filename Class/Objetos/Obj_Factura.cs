using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Facturacion.Class.Objetos
{
    internal class Obj_Factura
    {
        public Obj_Factura() { }

        private int idFactura, idCliente, idEmpleado, valorTotal, idEstado;        
        private float descuento, impuesto;        
        private string descripcion, nombreUsuario, nombreCliente, nombreEmpleado, estado;
        private DateTime dateTime;

        

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public float Descuento { get => descuento; set => descuento = value; }
        public float Impuesto { get => impuesto; set => impuesto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int ValorTotal { get => valorTotal; set => valorTotal = value; }
        public int IdEstado { get => idEstado; set => idEstado = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public int IdFactura { get => idFactura; set => idFactura = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }
        public string Estado { get => estado; set => estado = value; }

        public Obj_Factura(int idCliente, int idEmpleado, float descuento, float impuesto, string descripcion, int valorTotal, int idEstado, string nombreUsuario)
        {
            this.IdCliente = idCliente;
            this.IdEmpleado = idEmpleado;
            this.Descuento = descuento;
            this.Impuesto = impuesto;
            this.Descripcion = descripcion;
            this.ValorTotal = valorTotal;
            this.IdEstado = idEstado;
            this.NombreUsuario = nombreUsuario;
        }

        public Obj_Factura(int idFactura, string nombreCliente, string nombreEmpleado, DateTime dateTime, string estado)
        {

            this.IdEstado = idEstado;
            this.IdFactura = idFactura;
            this.NombreCliente = nombreCliente;
            this.NombreEmpleado = nombreEmpleado;
            this.DateTime = dateTime;
            this.Estado = estado;
        }


        public Obj_Factura(int idCliente, int idEmpleado, int descuento, int impuesto, DateTime dateTime, int idEstado, string descripcion)
        {
            this.IdCliente = idCliente;
            this.IdEmpleado = idEmpleado;
            this.Descuento = descuento;
            this.Impuesto = impuesto;
            this.DateTime = dateTime;
            this.IdEstado = idEstado;
            this.Descripcion = descripcion;

        }
    }
}
