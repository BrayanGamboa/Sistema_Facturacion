using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Capa_Acceso_De_Datos;

namespace Capa_Logica_De_Negocios.Class.Facturacion
{
    public class Obj_Factura
    {

        public Obj_Factura() { }

        private int idFactura, idCliente, idEmpleado, valorTotal, idEstado;
        private float descuento, impuesto;
        private string descripcion, nombreUsuario, nombreCliente, nombreEmpleado, estado;
        private DateTime dateTime;
        private NpgsqlDataReader Reader;



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

        //Factura
        public int New_Factura(Obj_Factura factura)
        {
            ConnectionDBt connection = new ConnectionDBt();

            int result = 0;
            try
            {
                string query = $"INSERT INTO TBLFACTURA (DtmFecha,IdCliente,IdEmpleado,NumDescuento,NumImpuesto,NumValorTotal,IdEstado,DtmFechaModifica)VALUES (current_timestamp,{factura.idCliente},{factura.idEmpleado},{factura.descuento},{factura.impuesto},{factura.valorTotal},{factura.idEstado},current_timestamp);";
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

        public List<Obj_Factura> GetFacturaList()
        {
            List<Obj_Factura> list = new List<Obj_Factura>();
            string query = "SELECT TBLFACTURA.IdFactura, TBLCLIENTES.StrNombre, TBLEMPLEADO.strNombre, TBLFACTURA.DtmFecha, TBLESTADO_FACTURA.StrDescripcion FROM TBLFACTURA JOIN TBLESTADO_FACTURA ON TBLFACTURA.IdEstado = TBLESTADO_FACTURA.IdEstadoFactura JOIN TBLCLIENTES ON TBLFACTURA.IdCliente = TBLCLIENTES.IdCliente JOIN TBLEMPLEADO ON TBLFACTURA.IdEmpleado = TBLEMPLEADO.IdEmpleado;";
            ConnectionDBt connection = new ConnectionDBt();

            try
            {
                var Command = connection.Consult(query);
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
                Console.WriteLine(err.Message);
            }
            connection.CloseConnection();
            return list;
        }

        public Obj_Factura GetFacturaForIdBusqueda(int idFactura)
        {
            
            string query = $"SELECT TBLFACTURA.IdFactura, TBLCLIENTES.StrNombre, TBLEMPLEADO.strNombre, TBLFACTURA.DtmFecha, TBLESTADO_FACTURA.StrDescripcion FROM TBLFACTURA JOIN TBLESTADO_FACTURA ON TBLFACTURA.IdEstado = TBLESTADO_FACTURA.IdEstadoFactura JOIN TBLCLIENTES ON TBLFACTURA.IdCliente = TBLCLIENTES.IdCliente JOIN TBLEMPLEADO ON TBLFACTURA.IdEmpleado = TBLEMPLEADO.IdEmpleado WHERE TBLFACTURA.IdFactura = {idFactura};";
            ConnectionDBt connection = new ConnectionDBt();
            Obj_Factura factura = new Obj_Factura();

            try
            {
                var Command = connection.Consult(query);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    factura.IdFactura = Reader.GetInt32(0);
                    factura.NombreCliente = Reader.GetString(1);
                    factura.NombreEmpleado = Reader.GetString(2);
                    factura.DateTime = Reader.GetDateTime(3);
                    factura.Estado = Reader.GetString(4);                    
                }
                Reader.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            connection.CloseConnection();
            return factura;
        }

        public Obj_Factura GetFacturaForId(int idFactura)
        {
            Obj_Factura factura = new Obj_Factura();

            string query = $"SELECT TBLFACTURA.IdFactura, TBLCLIENTES.StrNombre, TBLEMPLEADO.strNombre, TBLFACTURA.DtmFecha, TBLESTADO_FACTURA.StrDescripcion, TBLFACTURA.numdescuento, TBLFACTURA.numimpuesto, TBLFACTURA.numvalortotal FROM TBLFACTURA JOIN TBLESTADO_FACTURA ON TBLFACTURA.IdEstado = TBLESTADO_FACTURA.IdEstadoFactura JOIN TBLCLIENTES ON TBLFACTURA.IdCliente = TBLCLIENTES.IdCliente JOIN TBLEMPLEADO ON TBLFACTURA.IdEmpleado = TBLEMPLEADO.IdEmpleado WHERE IdFactura = {idFactura};";
            ConnectionDBt connection = new ConnectionDBt();
            try
            {
                var Command = connection.Consult(query);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    factura.IdFactura = Reader.GetInt32(0);
                    factura.NombreCliente = Reader.GetString(1);
                    factura.NombreEmpleado = Reader.GetString(2);
                    factura.DateTime = Reader.GetDateTime(3);
                    factura.Estado = Reader.GetString(4);
                    factura.descuento = Reader.GetInt32(5);
                    factura.impuesto = Reader.GetInt32(6);
                    factura.valorTotal = Reader.GetInt32(7);
                }
                Reader.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            connection.CloseConnection();
            return factura;
        }

        public int UpdateFactura(Obj_Factura factura)
        {
            ConnectionDBt connection = new ConnectionDBt();

            int result = 0;
            string query = $"UPDATE TBLFACTURA SET idcliente = {factura.idCliente}, idempleado = {factura.idEmpleado},numdescuento = {factura.descuento} ,numimpuesto = {factura.impuesto},numvalortotal ={factura.valorTotal},idestado = {factura.idEstado},dtmfechamodifica = current_timestamp WHERE idfactura = {factura.idFactura};";
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

        public int DeleteFacturaForId(int idFactura)
        {
            string query = $"DELETE FROM TBLFACTURA WHERE idfactura = {idFactura};";
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
