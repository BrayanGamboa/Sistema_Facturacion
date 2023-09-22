using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Facturacion.Class.Objetos
{
    internal class Obj_Categoria_Producto
    {


        private string descripcion, nombreUsuario;
        private int idCategoriaProducto ;

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public int IdCategoriaProducto { get => idCategoriaProducto; set => idCategoriaProducto = value; }

        public Obj_Categoria_Producto() { }

        public Obj_Categoria_Producto(string descripcion, string nombreUsuario)
        {
            this.Descripcion = descripcion;
            this.NombreUsuario = nombreUsuario;
        }

        public Obj_Categoria_Producto(int idCategoriaProducto, string descripcion)
        {
            this.Descripcion = descripcion;            
            this.IdCategoriaProducto = idCategoriaProducto;
        }

        public Obj_Categoria_Producto(string descripcion)
        {
            this.Descripcion = descripcion;            
        }

        public Obj_Categoria_Producto(int idCategoriaProducto)
        {
            this.IdCategoriaProducto = idCategoriaProducto;
        }
    }
}
