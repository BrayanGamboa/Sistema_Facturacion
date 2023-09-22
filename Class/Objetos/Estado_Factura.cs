using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Facturacion.Class.Objetos
{
    internal class Estado_Factura
    {
        public Estado_Factura() { }

        private string descripcion;
        private int idEstado;

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdEstado { get => idEstado; set => idEstado = value; }

        public Estado_Factura(string descripcion)
        {
            this.Descripcion = descripcion;
        }

        public Estado_Factura(string descripcion, int idEstado)
        {
            this.Descripcion = descripcion;
            this.IdEstado = idEstado;
        }
    }
}
