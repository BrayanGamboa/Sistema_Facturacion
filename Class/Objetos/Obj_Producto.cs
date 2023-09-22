using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Facturacion.Class.Objetos
{
    internal class Obj_Producto
    {
        public Obj_Producto() { }

  

        private string nombre, codigo, detalle, rutaFoto, nombreUsuaro, categoria;
        private int  idCategoria, cantidadStock, idProducto;
        private int precioCompra, precioVenta;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public string RutaFoto { get => rutaFoto; set => rutaFoto = value; }
        public string NombreUsuaro { get => nombreUsuaro; set => nombreUsuaro = value; }
        public int PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public int PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public int CantidadStock { get => cantidadStock; set => cantidadStock = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Categoria { get => categoria; set => categoria = value; }

        public Obj_Producto(string nombre, string codigo, string detalle, string rutaFoto, string nombreUsuaro, int precioCompra, int precioVenta, int idCategoria, int cantidadStock)
        {
            this.Nombre = nombre;
            this.Codigo = codigo;
            this.Detalle = detalle;
            this.RutaFoto = rutaFoto;
            this.NombreUsuaro = nombreUsuaro;
            this.PrecioCompra = precioCompra;
            this.PrecioVenta = precioVenta;
            this.IdCategoria = idCategoria;
            this.CantidadStock = cantidadStock;
        }

        public Obj_Producto(int idProducto, string nombre, int precioVenta, string categoria, int cantidadStock)
        {
            this.Nombre = nombre;
            this.PrecioVenta = precioVenta;
            this.Categoria = categoria;
            this.CantidadStock = cantidadStock;
            this.IdProducto = idProducto;
        }

        public Obj_Producto(string nombre, int precioVenta, string categoria, int cantidadStock)
        {
            this.Nombre = nombre;
            this.PrecioVenta = precioVenta;
            this.Categoria = categoria;
            this.CantidadStock = cantidadStock;
            
        }



    }
}
