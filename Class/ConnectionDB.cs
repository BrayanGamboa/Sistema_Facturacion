using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Npgsql;
using Sistema_Facturacion.Class.Objetos;
using Sistema_Facturacion.Forms.Cliente;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Sistema_Facturacion.Class
{
    internal class ConnectionDB
    {
        public ConnectionDB() { }
        private static string getChainDB()
        {
            string host_DB = "bcgignm2nyqyudv6zxh8-postgresql.services.clever-cloud.com";
            string port_DB = "5432";
            string name_DB = "bcgignm2nyqyudv6zxh8";
            string user_DB = "ugicnxasmrlwbj3bhr2y";
            string passwod_DB = "e7MjU37weRot42pcaQuqrUHWlrbQ4m";

            string chainConnection = string.Format($"Host={host_DB};Port={port_DB};Database={name_DB};UserName={user_DB};Password={passwod_DB};");

            return chainConnection;
        }

        private NpgsqlConnection Connection;
        private NpgsqlCommand Command;
        private NpgsqlDataReader Reader;

        //Conexión a la base de datos
        public void ManagerConnection()
        {
            try
            {
                Connection = new NpgsqlConnection(getChainDB());
                Connection.Open();

            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Alerta");
            }
        }


        //Clientes
        public int New_Cliente(Obj_Cliente cliente)
        {
            ManagerConnection();

            int result = 0;

            try
            {
                string query = "INSERT INTO TBLCLIENTES (StrNombre, NumDocumento,StrTelefono,StrEmail,DtmFechaModifica) VALUES (@nombre,@documento,@telefono,@email,current_timestamp);";

                Command = new NpgsqlCommand(query, Connection);

                Command.Parameters.AddWithValue("@nombre", cliente.Nombre);
                Command.Parameters.AddWithValue("@documento", cliente.Documento);
                Command.Parameters.AddWithValue("@telefono", cliente.Telefono);
                Command.Parameters.AddWithValue("@email", cliente.Email);


                result = Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Error");
            }
            Connection.Close();

            return result;

        }

        public List<Obj_Cliente> GetClienteList()
        {
            List<Obj_Cliente> list = new List<Obj_Cliente>();
            string query = "SELECT IdCliente, StrNombre,NumDocumento,StrTelefono FROM TBLCLIENTES;";
            ManagerConnection();

            try
            {
                Command = new NpgsqlCommand(query, Connection);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Obj_Cliente cliente = new Obj_Cliente();
                    cliente.IdCliente = Reader.GetInt32(0);
                    cliente.Nombre = Reader.GetString(1);
                    cliente.Documento = Reader.GetInt32(2);
                    cliente.Telefono = Reader.GetString(3);

                    list.Add(cliente);
                }
                Reader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Erro");
            }
            Connection.Close();
            return list;
        }

        public Obj_Cliente GetClienteId(string nombreUsuario)
        {
            Obj_Cliente cliente = new Obj_Cliente();
            string query = $"SELECT IdCliente, StrNombre,NumDocumento,StrTelefono, stremail FROM TBLCLIENTES WHERE StrNombre = '{nombreUsuario}';";
            ManagerConnection();

            try
            {
                Command = new NpgsqlCommand(query, Connection);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    cliente.IdCliente = Reader.GetInt32(0);
                    cliente.Nombre = Reader.GetString(1);
                    cliente.Documento= Reader.GetInt32(2);
                    cliente.Telefono= Reader.GetString(3);
                    cliente.Email = Reader.GetString(4);
                }
                Reader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Erro");
            }
            Connection.Close();
            return cliente;
        }

        public Obj_Cliente GetClienteForId(int idCliente)
        {
            
            string query = $"SELECT StrNombre,NumDocumento,StrTelefono, stremail FROM TBLCLIENTES WHERE IdCliente = {idCliente};";
            ManagerConnection();
            Obj_Cliente cliente = new Obj_Cliente();

            try
            {
                Command = new NpgsqlCommand(query, Connection);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {                    
                    cliente.Nombre = Reader.GetString(0);
                    cliente.Documento = Reader.GetInt32(1);
                    cliente.Telefono = Reader.GetString(2);
                    cliente.Email = Reader.GetString(3);

                }
                Reader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Erro");
            }
            Connection.Close();
            return cliente;
        }

        public int UpdateCliente(Obj_Cliente cliente)
        {
            
                ManagerConnection();
                int result = 0;
                string query = "UPDATE TBLCLIENTES SET StrNombre = @nombre, NumDocumento = @documento, StrTelefono =@telefono , stremail = @email WHERE IdCliente = @idCliente";
                try
                {
                    Command = new NpgsqlCommand(query, Connection);

                    Command.Parameters.AddWithValue("@documento", cliente.Documento);
                    Command.Parameters.AddWithValue("@nombre", cliente.Nombre);
                    Command.Parameters.AddWithValue("@email", cliente.Email);
                    Command.Parameters.AddWithValue("@telefono", cliente.Telefono);
                    Command.Parameters.AddWithValue("@idCliente", cliente.IdCliente);

                    result = Command.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Error: '{err.Message}'", "Error");
                }

                Connection.Close();
                return result;
            
        }

        public int DeleteClienteForId(int idCliente)
        {
            string query = $"DELETE FROM TBLCLIENTES WHERE idcliente = {idCliente};";
            ManagerConnection();
            Obj_Cliente cliente = new Obj_Cliente();
            int respuesta = 0;
            try
            {
                Command = new NpgsqlCommand(query, Connection);
                respuesta = Command.ExecuteNonQuery();
               
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Erro");
            }
            Connection.Close();
            return respuesta;
        }


        //Categoría de productos
        public int New_Categoria_Producto(Obj_Categoria_Producto categoriaProducto)
        {
            ManagerConnection();
            int result = 0;
            try
            {
                string query = "INSERT INTO TBLCATEGORIA_PROD (StrDescripcion,DtmFechaModifica)VALUES (@nombreCategoria, current_timestamp);";
                Command = new NpgsqlCommand(query, Connection);

                Command.Parameters.AddWithValue("@nombreCategoria", categoriaProducto.Descripcion);

                result = Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Error");
            }
            Connection.Close();

            return result;
        }

        public List<Obj_Categoria_Producto> GetCategoriaProductoList()
        {
            List<Obj_Categoria_Producto> list = new List<Obj_Categoria_Producto>();
            string query = "SELECT IdCategoria, StrDescripcion FROM TBLCATEGORIA_PROD;";
            ManagerConnection();

            try
            {
                Command = new NpgsqlCommand(query, Connection);
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
                MessageBox.Show($"Error: '{err.Message}'", "Erro");
            }
            Connection.Close();
            return list;
        }

        public Obj_Categoria_Producto GetCategoriaProductoId(string nombreCategoria)
        {
            Obj_Categoria_Producto categoria_Producto = new Obj_Categoria_Producto();
            string query = $"SELECT IdCategoria FROM TBLCATEGORIA_PROD WHERE StrDescripcion = '{nombreCategoria}';";
            ManagerConnection();


            try
            {
                Command = new NpgsqlCommand(query, Connection);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {

                    categoria_Producto.IdCategoriaProducto = Reader.GetInt32(0);
                }
                Reader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Erro");
            }
            Connection.Close();
            return categoria_Producto;
        }


        //Detalle de factura
        public int New_Detalle_Factura(Detalle_Factura detalle_Factura)
        {
            ManagerConnection();
            int result = 0;
            try
            {
                string query = "INSERT INTO TBLDETALLE_FACTURA (IdFactura, NumCantidad, IdProducto, NumPrecio) VALUES (@idFactura, @cantidadProducto, @idProducto, @precio);";
                Command = new NpgsqlCommand(query, Connection);

                Command.Parameters.AddWithValue("@idFactura", detalle_Factura.IdFactura);
                Command.Parameters.AddWithValue("@cantidadProducto", detalle_Factura.NumCantidad);
                Command.Parameters.AddWithValue("@idProducto", detalle_Factura.IdProducto);
                Command.Parameters.AddWithValue("@precio", detalle_Factura.NumPrecio);

                result = Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Error");
            }
            Connection.Close();

            return result;
        }


        //Empleado
        public int New_Empleado(Empleado empleado)
        {
            ManagerConnection();
            int result = 0;
            try
            {
                //string query2 = "INSERT INTO TBLSEGURIDAD (IdEmpleado,DtmFechaModifica) VALUES (@idEmpleado, current_timestamp);";

                //Command = new NpgsqlCommand(query2, Connection);

                //Command.Parameters.AddWithValue("@idEmpleado", seguridad.IdEmpleado);

                string query = "INSERT INTO TBLEMPLEADO (strNombre,NumDocumento,StrDireccion,StrTelefono,StrEmail,IdRolEmpleado,DtmIngreso,DtmRetiro,strDatosAdicionales,DtmFechaModifica)VALUES (@nombre,@documento,@direccion,@telefono,@email,@rolEmpleado,current_timestamp,current_timestamp,@datosAdicionales,current_timestamp);";
                Command = new NpgsqlCommand(query, Connection);

                Command.Parameters.AddWithValue("@nombre", empleado.Nombre);
                Command.Parameters.AddWithValue("@documento", empleado.Documento);
                Command.Parameters.AddWithValue("@direccion", empleado.Direccion);
                Command.Parameters.AddWithValue("@telefono", empleado.Telefono);
                Command.Parameters.AddWithValue("@email", empleado.Email);
                Command.Parameters.AddWithValue("@rolEmpleado", empleado.IdRolEmpleado);
                Command.Parameters.AddWithValue("@datosAdicionales", empleado.DatosAdicionales);
                result = Command.ExecuteNonQuery();

                if (result == 1)
                {
                    var idEmpleado = GetEmpleadoId(empleado.Nombre);

                    Seguridad newUsuario = new Seguridad(idEmpleado.IdEmpleado);
                    result = New_Seguridad(newUsuario);
                }
                else
                {
                    result = 0;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Error");
            }
            Connection.Close();

            return result;
        }
        public List<Empleado> GetEmpleadosList()
        {
            List<Empleado> list = new List<Empleado>();
            string query = "SELECT idempleado, strNombre, NumDocumento, StrTelefono FROM TBLEMPLEADO;";
            ManagerConnection();

            try
            {
                Command = new NpgsqlCommand(query, Connection);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {

                    Empleado empleado = new Empleado();

                    empleado.IdEmpleado = Reader.GetInt32(0);
                    empleado.Nombre = Reader.GetString(1);
                    empleado.Documento = Reader.GetInt32(2);
                    empleado.Telefono = Reader.GetString(3);


                    list.Add(empleado);
                }
                Reader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Erro");
            }
            Connection.Close();
            return list;
        }

        public Empleado GetEmpleadoId(string nombreUsuario)
        {
            Empleado empleado = new Empleado();
            string query = $"SELECT idempleado FROM TBLEMPLEADO WHERE strNombre = '{nombreUsuario}';";
            ManagerConnection();

            try
            {
                Command = new NpgsqlCommand(query, Connection);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {

                    empleado.IdEmpleado = Reader.GetInt32(0);


                }
                Reader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Erro");
            }
            Connection.Close();
            return empleado;
        }

        public Empleado GetDatosEmpleadoId(int idEmpleado)
        {
            Empleado empleado = new Empleado();
            string query = $"SELECT strnombre, NumDocumento, StrTelefono, stremail, strdireccion, strdatosadicionales, idrolempleado FROM TBLEMPLEADO WHERE idempleado = {idEmpleado};";
            int idRol = 0;
            ManagerConnection();

            try
            {
                Command = new NpgsqlCommand(query, Connection);
                Reader = Command.ExecuteReader();

                

                while (Reader.Read())
                {
                    empleado.Nombre = Reader.GetString(0);
                    empleado.Documento = Reader.GetInt32(1);
                    empleado.Telefono = Reader.GetString(2);
                    empleado.Email = Reader.GetString(3);
                    empleado.Direccion = Reader.GetString(4);
                    empleado.DatosAdicionales = Reader.GetString(5);
                    idRol = Reader.GetInt32(6);
                }
                Reader.Close();
                empleado.NombreRol = GetNombreRolId(idRol).NombreRol;
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Error");
            }
            Connection.Close();
            return empleado;
        }

        public int UpdateEmpleado(Empleado empleado)
        {

            ManagerConnection();
            int result = 0;
            string query = "UPDATE TBLEMPLEADO SET StrNombre = @nombre, NumDocumento = @documento, StrTelefono =@telefono , stremail = @email, strdireccion = @direccion, idrolempleado = @idRol, strdatosadicionales = @datosAdicionales, dtmfechamodifica = current_timestamp  WHERE idempleado = @idempleado;";
            try
            {
                Command = new NpgsqlCommand(query, Connection);

                Command.Parameters.AddWithValue("@documento", empleado.Documento);
                Command.Parameters.AddWithValue("@nombre", empleado.Nombre);
                Command.Parameters.AddWithValue("@email", empleado.Email);
                Command.Parameters.AddWithValue("@telefono", empleado.Telefono);
                Command.Parameters.AddWithValue("@idempleado", empleado.IdEmpleado);
                Command.Parameters.AddWithValue("@direccion", empleado.Direccion);
                Command.Parameters.AddWithValue("@idRol", empleado.IdRolEmpleado);
                Command.Parameters.AddWithValue("@datosAdicionales", empleado.DatosAdicionales);

                result = Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Error");
            }

            Connection.Close();
            return result;

        }

        public int DeleteEmpleadoForId(int idEmpleado)
        {
            string query = $"DELETE FROM TBLEMPLEADO WHERE idempleado = {idEmpleado};";
            ManagerConnection();
            
            int respuesta = 0;
            try
            {
                Command = new NpgsqlCommand(query, Connection);
                respuesta = Command.ExecuteNonQuery();

            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Error");
            }
            Connection.Close();
            return respuesta;
        }

        //Estado factura
        public int New_Estado_Factura(Estado_Factura estado_Factura)
        {
            ManagerConnection();
            int result = 0;
            try
            {
                string query = "INSERT INTO TBLESTADO_FACTURA (StrDescripcion) VALUES (@nombreEstado);";
                Command = new NpgsqlCommand(query, Connection);

                Command.Parameters.AddWithValue("@nombreEstado", estado_Factura.Descripcion);

                result = Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Error");
            }
            Connection.Close();

            return result;
        }

        public List<Estado_Factura> GetEstadoFacturaList()
        {
            List<Estado_Factura> list = new List<Estado_Factura>();
            string query = "SELECT IdEstadoFactura, StrDescripcion FROM TBLESTADO_FACTURA;";
            ManagerConnection();

            try
            {
                Command = new NpgsqlCommand(query, Connection);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {

                    Estado_Factura estado_factura = new Estado_Factura();

                    estado_factura.IdEstado = Reader.GetInt32(0);
                    estado_factura.Descripcion = Reader.GetString(1);

                    list.Add(estado_factura);
                }
                Reader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Erro");
            }
            Connection.Close();
            return list;
        }

        public Estado_Factura GetEstadoFacturaId(string nombreEstado)
        {
            Estado_Factura estadoId = new Estado_Factura();
            string query = $"SELECT IdEstadoFactura FROM TBLESTADO_FACTURA WHERE StrDescripcion = '{nombreEstado}';";
            ManagerConnection();

            try
            {
                Command = new NpgsqlCommand(query, Connection);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    estadoId.IdEstado = Reader.GetInt32(0);
                }
                Reader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Erro");
            }
            Connection.Close();
            return estadoId;
        }


        //Factura
        public int New_Factura(Obj_Factura factura)
        {
            ManagerConnection();
            int result = 0;
            try
            {
                string query = "INSERT INTO TBLFACTURA (DtmFecha,IdCliente,IdEmpleado,NumDescuento,NumImpuesto,NumValorTotal,IdEstado,DtmFechaModifica)VALUES (current_timestamp,@idCliente,@idEmpleado,@numDescuento,@impuesto,@valorTotal,@idEstado,current_timestamp);";
                Command = new NpgsqlCommand(query, Connection);

                Command.Parameters.AddWithValue("@idCliente", factura.IdCliente);
                Command.Parameters.AddWithValue("@idEmpleado", factura.IdEmpleado);
                Command.Parameters.AddWithValue("@numDescuento", factura.Descuento);
                Command.Parameters.AddWithValue("@impuesto", factura.Impuesto);
                Command.Parameters.AddWithValue("@valorTotal", factura.ValorTotal);
                Command.Parameters.AddWithValue("@idEstado", factura.IdEstado);


                result = Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Error");
            }
            Connection.Close();

            return result;
        }

        public List<Obj_Factura> GetFacturaList()
        {
            List<Obj_Factura> list = new List<Obj_Factura>();
            string query = "SELECT TBLFACTURA.IdFactura, TBLCLIENTES.StrNombre, TBLEMPLEADO.strNombre, TBLFACTURA.DtmFecha, TBLESTADO_FACTURA.StrDescripcion FROM TBLFACTURA JOIN TBLESTADO_FACTURA ON TBLFACTURA.IdEstado = TBLESTADO_FACTURA.IdEstadoFactura JOIN TBLCLIENTES ON TBLFACTURA.IdCliente = TBLCLIENTES.IdCliente JOIN TBLEMPLEADO ON TBLFACTURA.IdEmpleado = TBLEMPLEADO.IdEmpleado;";
            ManagerConnection();

            try
            {
                Command = new NpgsqlCommand(query, Connection);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Obj_Factura factura = new Obj_Factura();

                    factura.IdFactura = Reader.GetInt32(0);
                    factura.NombreCliente = Reader.GetString(1);
                    factura.NombreEmpleado = Reader.GetString(2);
                    factura.DateTime = Reader.GetDateTime(3);
                    factura.Estado = Reader.GetString(4);

                    list.Add(factura);
                }
                Reader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Erro");
            }
            Connection.Close();
            return list;
        }


        //Producto
        public int New_Producto(Obj_Producto producto)
        {
            ManagerConnection();
            int result = 0;
            try
            {
                string query = "INSERT INTO TBLPRODUCTO (StrNombre,StrCodigo,NumPrecioCompra,NumPrecioVenta,IdCategoria,StrDetalle,strFoto,NumStock,DtmFechaModifica) VALUES (@nombreProducto,@codigo,@precioCompra,@precioVenta,@idCategoria,@detalle,@rutaFoto,@cantidadStock,current_timestamp);";
                Command = new NpgsqlCommand(query, Connection);

                Command.Parameters.AddWithValue("@nombreProducto", producto.Nombre);
                Command.Parameters.AddWithValue("@codigo", producto.Codigo);
                Command.Parameters.AddWithValue("@precioCompra", producto.PrecioCompra);
                Command.Parameters.AddWithValue("@precioVenta", producto.PrecioVenta);
                Command.Parameters.AddWithValue("@idCategoria", producto.IdCategoria);
                Command.Parameters.AddWithValue("@detalle", producto.Detalle);
                Command.Parameters.AddWithValue("@rutaFoto", producto.RutaFoto);
                Command.Parameters.AddWithValue("@cantidadStock", producto.CantidadStock);


                result = Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Error");
            }
            Connection.Close();

            return result;
        }

        public List<Obj_Producto> GetProductoList()
        {
            List<Obj_Producto> list = new List<Obj_Producto>();
            string query = "SELECT TBLPRODUCTO.IdProducto,TBLPRODUCTO.StrNombre,TBLCATEGORIA_PROD.StrDescripcion,TBLPRODUCTO.NumPrecioVenta,TBLPRODUCTO.NumStock FROM TBLPRODUCTO JOIN TBLCATEGORIA_PROD ON TBLPRODUCTO.IdCategoria = TBLCATEGORIA_PROD.IdCategoria;";
            ManagerConnection();

            try
            {
                Command = new NpgsqlCommand(query, Connection);
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
                MessageBox.Show($"Error: '{err.Message}'", "Erro");
            }
            Connection.Close();
            return list;
        }

        public Obj_Producto GetProductoForId(int idProducto)
        {
            Obj_Producto producto = new Obj_Producto();
            string query = $"SELECT StrNombre,strcodigo, numpreciocompra,NumPrecioVenta, idcategoria, strdetalle, strfoto,NumStock FROM TBLPRODUCTO WHERE IdProducto = {idProducto};";
            ManagerConnection();
            try
            {
                Command = new NpgsqlCommand(query, Connection);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    producto.Nombre = Reader.GetString(0);
                    producto.Codigo = Reader.GetString(1);
                    producto.PrecioCompra = Reader.GetInt32(2);
                    producto.PrecioVenta = Reader.GetInt32(3);
                    producto.IdCategoria = Reader.GetInt32(4);
                    producto.Detalle = Reader.GetString(5);
                    producto.RutaFoto= Reader.GetString(6);
                    producto.CantidadStock = Reader.GetInt32(7);
                }
                Reader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Erro");
            }
            Connection.Close();
            return producto;
        }

        public int UpdateProducto(Obj_Producto producto)
        {

            ManagerConnection();
            int result = 0;
            string query = "UPDATE TBLPRODUCTO SET StrNombre = @nombreProducto, StrCodigo = @codigo,NumPrecioCompra = @precioCompra ,NumPrecioVenta = @precioVenta,IdCategoria =@idCategoria,StrDetalle = @detalle,strFoto = @rutaFoto,NumStock = @stock,DtmFechaModifica = current_timestamp WHERE IdProducto = @idProducto;";
            try
            {
                Command = new NpgsqlCommand(query, Connection);
               
                Command.Parameters.AddWithValue("@nombreProducto", producto.Nombre);
                Command.Parameters.AddWithValue("@codigo", producto.Codigo);
                Command.Parameters.AddWithValue("@precioCompra", producto.PrecioCompra);
                Command.Parameters.AddWithValue("@precioVenta", producto.PrecioVenta);
                Command.Parameters.AddWithValue("@idCategoria", producto.IdCategoria);
                Command.Parameters.AddWithValue("@detalle", producto.Detalle);
                Command.Parameters.AddWithValue("@rutaFoto", producto.RutaFoto);
                Command.Parameters.AddWithValue("@stock", producto.CantidadStock);
                Command.Parameters.AddWithValue("@idProducto", producto.IdProducto);

                result = Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Error");
            }

            Connection.Close();
            return result;
        }

        public int DeleteProductoForId(int idProducto)
        {
            string query = $"DELETE FROM TBLPRODUCTO WHERE IdProducto = {idProducto};";
            ManagerConnection();

            int respuesta = 0;
            try
            {
                Command = new NpgsqlCommand(query, Connection);
                respuesta = Command.ExecuteNonQuery();

            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Error");
            }
            Connection.Close();
            return respuesta;
        }


        //Rol
        public int New_Rol(Obj_Rol rol)
        {
            ManagerConnection();
            int result = 0;
            try
            {
                string query = "INSERT INTO TBLROLES (StrDescripcion)VALUES (@nombreRol);";
                Command = new NpgsqlCommand(query, Connection);

                Command.Parameters.AddWithValue("@nombreRol", rol.NombreRol);

                result = Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Error");
            }
            Connection.Close();

            return result;
        }
        public List<Obj_Rol> GetRolList()
        {
            List<Obj_Rol> list = new List<Obj_Rol>();
            string query = "SELECT * FROM TBLROLES;";
            ManagerConnection();

            try
            {
                Command = new NpgsqlCommand(query, Connection);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Obj_Rol rol = new Obj_Rol();

                    rol.IdRol = Reader.GetInt32(0);
                    rol.NombreRol = Reader.GetString(1);

                    list.Add(rol);
                }
                Reader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'");
            }
            Connection.Close();
            return list;
        }

        public Obj_Rol GetRolId(string nombreRol)
        {
            Obj_Rol rol = new Obj_Rol();
            string query = $"SELECT idrolempleado FROM TBLROLES WHERE strdescripcion = '{nombreRol}';";
            ManagerConnection();

            try
            {
                Command = new NpgsqlCommand(query, Connection);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    rol.IdRol = Reader.GetInt32(0);
                }
                Reader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'");
            }
            Connection.Close();
            return rol;
        }

        public Obj_Rol GetNombreRolId(int idRol)
        {
            Obj_Rol rol = new Obj_Rol();
            string query = $"SELECT strdescripcion FROM TBLROLES WHERE  idrolempleado = {idRol};";
            ManagerConnection();

            try
            {
                Command = new NpgsqlCommand(query, Connection);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    rol.NombreRol = Reader.GetString(0);
                }
                Reader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'");
            }
            Connection.Close();
            return rol;
        }


        //Seguridad
        public int New_Seguridad(Seguridad seguridad)
        {
            ManagerConnection();
            int result = 0;
            try
            {
                string query = "INSERT INTO TBLSEGURIDAD (IdEmpleado,StrUsuario,StrClave,DtmFechaModifica )VALUES (@idEmpleado,@usuario,@clave,current_timestamp);";

                Command = new NpgsqlCommand(query, Connection);

                Command.Parameters.AddWithValue("@idEmpleado", seguridad.IdEmpleado);
                if (string.IsNullOrEmpty(seguridad.NombreUsuario) || string.IsNullOrEmpty(seguridad.Contrasena))
                {
                    Command.Parameters.AddWithValue("@usuario", "");
                    Command.Parameters.AddWithValue("@clave", "");
                }
                else
                {
                    Command.Parameters.AddWithValue("@usuario", seguridad.NombreUsuario);
                    Command.Parameters.AddWithValue("@clave", seguridad.Contrasena);
                }

                result = Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Error");
            }
            Connection.Close();

            return result;
        }

        public List<Seguridad> GetSeguridadList()
        {
            List<Seguridad> list = new List<Seguridad>();
            string query = "SELECT TBLSEGURIDAD.IdSeguridad, TBLEMPLEADO.strNombre, TBLSEGURIDAD.StrUsuario, TBLSEGURIDAD.StrClave FROM TBLSEGURIDAD JOIN TBLEMPLEADO ON TBLSEGURIDAD.IdEmpleado = TBLEMPLEADO.IdEmpleado;";
            ManagerConnection();

            try
            {
                Command = new NpgsqlCommand(query, Connection);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Seguridad seguridad = new Seguridad();
                    seguridad.IdSeguridad = Reader.GetInt32(0);
                    seguridad.NombreEmpleado = Reader.GetString(1);
                    seguridad.NombreUsuario = Reader.GetString(2);
                    seguridad.Contrasena = Reader.GetString(3);

                    list.Add(seguridad);
                }
                Reader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'");
            }
            Connection.Close();
            return list;
        }

        public Seguridad GetCredenciales(string nombre)
        {
            string query = $"SELECT TBLSEGURIDAD.StrUsuario, TBLSEGURIDAD.StrClave FROM TBLSEGURIDAD JOIN TBLEMPLEADO ON TBLEMPLEADO.IdEmpleado = TBLSEGURIDAD.IdEmpleado WHERE strNombre = '{nombre}';";
            ManagerConnection();
            Seguridad credenciales = new Seguridad();

            try
            {
                Command = new NpgsqlCommand(query, Connection);
                Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    credenciales.NombreUsuario = Reader.GetString(0);
                    credenciales.Contrasena = Reader.GetString(1);
                }
                Reader.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'");
            }
            Connection.Close();
            return credenciales;
        }

        public Empleado GetNombre(string nombre)
        {
            string query = $"SELECT TBLEMPLEADO.strNombre FROM TBLSEGURIDAD JOIN TBLEMPLEADO ON TBLEMPLEADO.IdEmpleado = TBLSEGURIDAD.IdEmpleado WHERE StrUsuario = '{nombre}';";
            ManagerConnection();

            Empleado empleado = new Empleado();

            try
            {
                Command = new NpgsqlCommand(query, Connection);
                Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    empleado.Nombre = Reader.GetString(0);
                }
                Reader.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'");
            }
            Connection.Close();
            return empleado;
        }

        public Empleado GetId(string nombre)
        {
            string query = $"SELECT IdEmpleado WHERE StrUsuario = '{nombre}';";
            ManagerConnection();

            Empleado empleado = new Empleado();

            try
            {
                Command = new NpgsqlCommand(query, Connection);
                Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    empleado.Nombre = Reader.GetString(0);
                }
                Reader.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'");
            }
            Connection.Close();
            return empleado;
        }

        public int UpdateCredenciales(Obj_Login cliente)
        {
            ManagerConnection();
            int result = 0;
            string query = "UPDATE TBLSEGURIDAD SET StrUsuario = @nombreUsuario, StrClave = @contrasena, dtmfechamodifica = current_timestamp  WHERE idempleado = @idEmpleado;";
            try
            {
                Command = new NpgsqlCommand(query, Connection);

                Command.Parameters.AddWithValue("@contrasena", cliente.Contrasena);
                Command.Parameters.AddWithValue("@nombreUsuario", cliente.Usuario);                
                Command.Parameters.AddWithValue("@idEmpleado", cliente.IdEmpleado);

                result = Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Error");
            }

            Connection.Close();
            return result;

        }


        //Validar login

        public int ValidarCredenciales(Obj_Login login)
        {
            Obj_Login credencialesValidacion = new Obj_Login();
            string query = $"SELECT StrUsuario, StrClave FROM TBLSEGURIDAD WHERE StrUsuario = '{login.Usuario}';";
            ManagerConnection();

            try
            {
                Command = new NpgsqlCommand(query, Connection);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    credencialesValidacion.Usuario = Reader.GetString(0);
                    credencialesValidacion.Contrasena = Reader.GetString(1);
                }
                Reader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'");
            }
            Connection.Close();
            if (login.Usuario == credencialesValidacion.Usuario || login.Contrasena == credencialesValidacion.Contrasena)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
