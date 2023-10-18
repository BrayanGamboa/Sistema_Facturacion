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
    public class Obj_Cliente
    {
        public Obj_Cliente() { }


        private int documento, idCliente;
        private string nombre, direccion, email, fechaIngreso, fechaRestiro, fechaModificacion, telefono;
        private NpgsqlDataReader Reader;




        private string nombreUsuario;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Documento { get => documento; set => documento = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public string FechaRestiro { get => fechaRestiro; set => fechaRestiro = value; }
        public string FechaModificacion { get => fechaModificacion; set => fechaModificacion = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }

        public Obj_Cliente(string nombre, int documento, string direccion, string telefono, string email, string nombreUsuario)
        {
            this.Nombre = nombre;
            this.Documento = documento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
            this.NombreUsuario = nombreUsuario;
        }

        public Obj_Cliente(int idCliente, string nombre, int documento, string telefono)
        {
            this.IdCliente = idCliente;
            this.Nombre = nombre;
            this.Documento = documento;
            this.Telefono = telefono;
        }

        public Obj_Cliente(string nombre, int documento, string telefono, string email)
        {
            this.Nombre = nombre;
            this.Documento = documento;
            this.Telefono = telefono;
            this.Email = email;
        }

        public Obj_Cliente(int idCliente)
        {
            this.IdCliente = idCliente;
        }

        //Clientes
        public int New_Cliente(Obj_Cliente cliente)
        {
            ConnectionDBt connection = new ConnectionDBt();
            int result = 0;
            try
            {
                string query = $"INSERT INTO TBLCLIENTES (StrNombre, NumDocumento,StrTelefono,StrEmail,DtmFechaModifica) VALUES ('{cliente.nombre}',{cliente.documento},'{cliente.telefono}','{cliente.email}',current_timestamp);";
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

        public List<Obj_Cliente> GetClienteList()
        {
            List<Obj_Cliente> list = new List<Obj_Cliente>();
            string query = "SELECT IdCliente, StrNombre,NumDocumento,StrTelefono FROM TBLCLIENTES;";
            ConnectionDBt connection = new ConnectionDBt();

            try
            {
                var Command = connection.Consult(query);
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
                Console.WriteLine(err.Message);
            }
            connection.CloseConnection();
            return list;
        }

        public Obj_Cliente GetClienteId(string nombreUsuario)
        {
            Obj_Cliente cliente = new Obj_Cliente();
            string query = $"SELECT IdCliente, StrNombre,NumDocumento,StrTelefono, stremail FROM TBLCLIENTES WHERE StrNombre = '{nombreUsuario}';";
            ConnectionDBt connection = new ConnectionDBt();

            try
            {
                var Command = connection.Consult(query);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    cliente.IdCliente = Reader.GetInt32(0);
                    cliente.Nombre = Reader.GetString(1);
                    cliente.Documento = Reader.GetInt32(2);
                    cliente.Telefono = Reader.GetString(3);
                    cliente.Email = Reader.GetString(4);
                }
                Reader.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            connection.CloseConnection();
            return cliente;
        }

        public Obj_Cliente GetClienteForId(int idCliente)
        {

            string query = $"SELECT StrNombre,NumDocumento,StrTelefono, stremail FROM TBLCLIENTES WHERE IdCliente = {idCliente};";
            ConnectionDBt connection = new ConnectionDBt();
            Obj_Cliente cliente = new Obj_Cliente();

            try
            {
                var Command = connection.Consult(query);
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
                Console.WriteLine(err.Message);
            }
            connection.CloseConnection();
            return cliente;
        }

        public int UpdateCliente(Obj_Cliente cliente)
        {

            ConnectionDBt connection = new ConnectionDBt();
            int result = 0;
            string query = $"UPDATE TBLCLIENTES SET StrNombre = '{cliente.nombre}', NumDocumento = {cliente.documento}, StrTelefono = {cliente.telefono} , stremail = '{cliente.email}' WHERE IdCliente = {cliente.idCliente};";
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
        public int DeleteClienteForId(int idCliente)
        {
            ConnectionDBt connection = new ConnectionDBt();            
            string query = $"DELETE FROM TBLCLIENTES WHERE idcliente = {idCliente};";

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

