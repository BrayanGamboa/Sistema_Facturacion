using Capa_Acceso_De_Datos;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica_De_Negocios
{
    public class Obj_Producto
    {
        public Obj_Producto() { }

        private string nombre, codigo, detalle, rutaFoto, nombreUsuaro, categoria;
        private int idCategoria, cantidadStock, idProducto;
        private int precioCompra, precioVenta;        
        private NpgsqlDataReader Reader;
        
        


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

        public int New_Producto(Obj_Producto product)
        {

            ConnectionDBt connection = new ConnectionDBt();

            int result = 0;
            try
            {
                string query = $"INSERT INTO TBLPRODUCTO (StrNombre,StrCodigo,NumPrecioCompra,NumPrecioVenta,IdCategoria,StrDetalle,strFoto,NumStock,DtmFechaModifica) VALUES ('{product.Nombre}','{product.Codigo}',{product.PrecioCompra},{product.precioVenta},{product.idCategoria},'{product.detalle}','{product.rutaFoto}',{product.cantidadStock},current_timestamp);";                               
                result = connection.InsertUpdate(query);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                result = 0;
            }
            connection.CloseConnection();
            return result;
        }

        public List<Obj_Producto> GetProductoList()
        {
            List<Obj_Producto> list = new List<Obj_Producto>();
            string query = "SELECT TBLPRODUCTO.IdProducto,TBLPRODUCTO.StrNombre,TBLCATEGORIA_PROD.StrDescripcion,TBLPRODUCTO.NumPrecioVenta,TBLPRODUCTO.NumStock FROM TBLPRODUCTO JOIN TBLCATEGORIA_PROD ON TBLPRODUCTO.IdCategoria = TBLCATEGORIA_PROD.IdCategoria ;";
            ConnectionDBt connection = new ConnectionDBt();

            try
            {
                var Command = connection.Consult(query);
                Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    Obj_Producto producto = new Obj_Producto();

                    producto.IdProducto = Reader.GetInt32(0);
                    producto.Nombre = Reader.GetString(1);
                    producto.Categoria = Reader.GetString(2);
                    producto.PrecioVenta = Reader.GetInt32(3);
                    producto.CantidadStock = Reader.GetInt32(4);

                    list.Add(producto);
                }
                Reader.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            connection.CloseConnection();
            return list;
        }

        public Obj_Producto GetProductoForId(int idProducto)
        {
            Obj_Producto producto = new Obj_Producto();
            string query = $"SELECT StrNombre,strcodigo, numpreciocompra,NumPrecioVenta, idcategoria, strdetalle, strfoto,NumStock FROM TBLPRODUCTO WHERE IdProducto = {idProducto};";
            ConnectionDBt connection = new ConnectionDBt();
            try
            {
                var Command = connection.Consult(query);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    producto.Nombre = Reader.GetString(0);
                    producto.Codigo = Reader.GetString(1);
                    producto.PrecioCompra = Reader.GetInt32(2);
                    producto.PrecioVenta = Reader.GetInt32(3);
                    producto.IdCategoria = Reader.GetInt32(4);
                    producto.Detalle = Reader.GetString(5);
                    producto.RutaFoto = Reader.GetString(6);
                    producto.CantidadStock = Reader.GetInt32(7);
                }
                Reader.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            connection.CloseConnection();
            return producto;
        }

        public Obj_Producto GetProductoForName(string nameProducto)
        {
            
            string query = $"SELECT TBLPRODUCTO.IdProducto,TBLPRODUCTO.StrNombre,TBLCATEGORIA_PROD.StrDescripcion,TBLPRODUCTO.NumPrecioVenta,TBLPRODUCTO.NumStock FROM TBLPRODUCTO JOIN TBLCATEGORIA_PROD ON TBLPRODUCTO.IdCategoria = TBLCATEGORIA_PROD.IdCategoria WHERE TBLPRODUCTO.StrNombre = '{nameProducto}';";
            ConnectionDBt connection = new ConnectionDBt();
            Obj_Producto producto = new Obj_Producto();

            try
            {
                var Command = connection.Consult(query);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {                    
                    producto.IdProducto = Reader.GetInt32(0);
                    producto.Nombre = Reader.GetString(1);
                    producto.Categoria = Reader.GetString(2);
                    producto.PrecioVenta = Reader.GetInt32(3);
                    producto.CantidadStock = Reader.GetInt32(4);
                }
                Reader.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            connection.CloseConnection();
            return producto;
        }

        public int UpdateProducto(Obj_Producto producto)
        {

            ConnectionDBt connection = new ConnectionDBt();

            int result = 0;
            string query = $"UPDATE TBLPRODUCTO SET StrNombre = '{producto.nombre}', StrCodigo = '{producto.codigo}',NumPrecioCompra = {producto.precioCompra} ,NumPrecioVenta = {producto.precioVenta},IdCategoria ={producto.idCategoria},StrDetalle = '{producto.detalle}',strFoto = '{producto.rutaFoto}',NumStock = {producto.cantidadStock},DtmFechaModifica = current_timestamp WHERE IdProducto = {producto.idProducto};";
            try
            {                                
                result = connection.InsertUpdate(query);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                result = 0;
            }
            connection.CloseConnection();
            return result;
        }

        public int DeleteProductoForId(int idProducto)
        {
            string query = $"DELETE FROM TBLPRODUCTO WHERE IdProducto = {idProducto};";
            ConnectionDBt connection = new ConnectionDBt();

            int result = 0;
            try
            {
                result = connection.InsertUpdate(query);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                result = 0;
            }
            connection.CloseConnection();
            return result;
        }



    }
}
