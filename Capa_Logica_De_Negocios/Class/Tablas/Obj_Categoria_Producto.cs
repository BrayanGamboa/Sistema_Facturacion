using Capa_Acceso_De_Datos;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica_De_Negocios.Class.Tablas
{
    public class Obj_Categoria_Producto
    {

        private string descripcion, nombreUsuario;
        private int idCategoriaProducto;
        private NpgsqlDataReader Reader;

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

        //Categoría de productos
        public int New_Categoria_Producto(Obj_Categoria_Producto categoriaProducto)
        {
            ConnectionDBt connection = new ConnectionDBt();
            int result = 0;
            try
            {
                string query = $"INSERT INTO TBLCATEGORIA_PROD (StrDescripcion,DtmFechaModifica)VALUES ('{categoriaProducto.Descripcion}', current_timestamp);";
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

        public List<Obj_Categoria_Producto> GetCategoriaProductoList()
        {
            List<Obj_Categoria_Producto> list = new List<Obj_Categoria_Producto>();
            string query = "SELECT IdCategoria, StrDescripcion FROM TBLCATEGORIA_PROD;";
            ConnectionDBt connection = new ConnectionDBt();

            try
            {
                var Command = connection.Consult(query);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Obj_Categoria_Producto categoria = new Obj_Categoria_Producto();

                    categoria.IdCategoriaProducto = Reader.GetInt32(0);
                    categoria.Descripcion = Reader.GetString(1);
                    list.Add(categoria);
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

        public Obj_Categoria_Producto GetCategoriaProductoForName(string nameCategoria)
        {            
            string query = $"SELECT IdCategoria, StrDescripcion FROM TBLCATEGORIA_PROD WHERE StrDescripcion = '{nameCategoria}';";
            ConnectionDBt connection = new ConnectionDBt();
            Obj_Categoria_Producto categoria = new Obj_Categoria_Producto();

            try
            {
                var Command = connection.Consult(query);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {

                    categoria.IdCategoriaProducto = Reader.GetInt32(0);
                    categoria.Descripcion = Reader.GetString(1);
                    
                }
                Reader.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            connection.CloseConnection();
            return categoria;
        }

        public Obj_Categoria_Producto GetCategoriaProductoId(string nombreCategoria)
        {
            Obj_Categoria_Producto categoria_Producto = new Obj_Categoria_Producto();
            string query = $"SELECT IdCategoria FROM TBLCATEGORIA_PROD WHERE StrDescripcion = '{nombreCategoria}';";
            ConnectionDBt connection = new ConnectionDBt();
            try
            {
                var Command = connection.Consult(query);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    categoria_Producto.IdCategoriaProducto = Reader.GetInt32(0);
                }
                Reader.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            connection.CloseConnection();              
            return categoria_Producto;
        }

        public Obj_Categoria_Producto GetCategoriaProductoId_(int idCategoria)
        {
            Obj_Categoria_Producto categoria_Producto = new Obj_Categoria_Producto();
            string query = $"SELECT StrDescripcion IdCategoria FROM TBLCATEGORIA_PROD WHERE IdCategoria = {idCategoria};";
            ConnectionDBt connection = new ConnectionDBt();
            try
            {
                var Command = connection.Consult(query);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    categoria_Producto.descripcion = Reader.GetString(0);
                }
                Reader.Close();
                categoria_Producto.idCategoriaProducto = idCategoria;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            connection.CloseConnection();
            return categoria_Producto;
        }

        public int UpdateCategoriaProducto(Obj_Categoria_Producto obj_Categoria_Producto)
        {
            ConnectionDBt connection = new ConnectionDBt();
            int result = 0;
            string query = $"UPDATE TBLCATEGORIA_PROD SET StrDescripcion = '{obj_Categoria_Producto.descripcion}', dtmfechamodifica = current_timestamp WHERE IdCategoria = {obj_Categoria_Producto.idCategoriaProducto};";
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

        public int DeleteCategoriaProductoId(int idCategoria)
        {
            string query = $"DELETE FROM TBLCATEGORIA_PROD WHERE IdCategoria = {idCategoria};";
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
