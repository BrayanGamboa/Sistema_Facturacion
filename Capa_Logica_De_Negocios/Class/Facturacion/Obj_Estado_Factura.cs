using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Capa_Acceso_De_Datos;

namespace Capa_Logica_De_Negocios.Class
{
    public class Obj_Estado_Factura
    {
        public Obj_Estado_Factura() { }

        private string descripcion;
        private int idEstado;
        private NpgsqlDataReader Reader;


        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdEstado { get => idEstado; set => idEstado = value; }

        public Obj_Estado_Factura(string descripcion)
        {
            this.Descripcion = descripcion;
        }

        public Obj_Estado_Factura(string descripcion, int idEstado)
        {
            this.Descripcion = descripcion;
            this.IdEstado = idEstado;
        }

        //Estado factura
        public int New_Estado_Factura(Obj_Estado_Factura estado_Factura)
        {
            ConnectionDBt connection = new ConnectionDBt();
            int result = 0;
            try
            {
                string query = $"INSERT INTO TBLESTADO_FACTURA (StrDescripcion) VALUES ('{estado_Factura.Descripcion}');";
                result = connection.InsertUpdate(query);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);

            }
            connection.CloseConnection();

            return result;
        }

        public List<Obj_Estado_Factura> GetEstadoFacturaList()
        {
            List<Obj_Estado_Factura> list = new List<Obj_Estado_Factura>();
            string query = "SELECT IdEstadoFactura, StrDescripcion FROM TBLESTADO_FACTURA;";
            ConnectionDBt connection = new ConnectionDBt();

            try
            {
                var Command = connection.Consult(query);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {

                    Obj_Estado_Factura estado_factura = new Obj_Estado_Factura();

                    estado_factura.IdEstado = Reader.GetInt32(0);
                    estado_factura.Descripcion = Reader.GetString(1);

                    list.Add(estado_factura);
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

        public Obj_Estado_Factura GetEstadoFacturaId(string nombreEstado)
        {
            Obj_Estado_Factura estadoId = new Obj_Estado_Factura();
            string query = $"SELECT IdEstadoFactura FROM TBLESTADO_FACTURA WHERE StrDescripcion = '{nombreEstado}';";
            ConnectionDBt connection = new ConnectionDBt();

            try
            {
                var Command = connection.Consult(query);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    estadoId.IdEstado = Reader.GetInt32(0);
                }
                Reader.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            connection.CloseConnection();
            return estadoId;
        }

    }
}
