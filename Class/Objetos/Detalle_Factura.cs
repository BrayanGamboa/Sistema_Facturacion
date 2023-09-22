using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Facturacion.Class.Objetos
{
    internal class Detalle_Factura
    {
        public Detalle_Factura() { }

        private int idFactura, numCantidad, idProducto, numPrecio;

        public int IdFactura { get => idFactura; set => idFactura = value; }
        public int NumCantidad { get => numCantidad; set => numCantidad = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int NumPrecio { get => numPrecio; set => numPrecio = value; }

        public Detalle_Factura(int idFactura, int numCantidad, int idProducto, int numPrecio)
        {
            this.IdFactura = idFactura;
            this.NumCantidad = numCantidad;
            this.IdProducto = idProducto;
            this.NumPrecio = numPrecio;
        }
    }
}
