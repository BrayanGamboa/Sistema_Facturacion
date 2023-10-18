using Capa_Acceso_De_Datos;
using Capa_Logica_De_Negocios.Class;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica_De_Negocios
{
    public class Obj_Empleado
    {

        public Obj_Empleado() { }

        private string nombre, direccion, email, datosAdicionales, nombreRol, telefono;
        private int documento, idRolEmpleado, idEmpleado;
        private NpgsqlDataReader Reader;



        public string Nombre { get => nombre; set => nombre = value; }
        public int Documento { get => documento; set => documento = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int IdRolEmpleado { get => idRolEmpleado; set => idRolEmpleado = value; }
        public string Email { get => email; set => email = value; }
        public string DatosAdicionales { get => datosAdicionales; set => datosAdicionales = value; }
        public string NombreRol { get => nombreRol; set => nombreRol = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }

        public Obj_Empleado(string nombre, int documento, string direccion, string telefono, int idRolEmpleado, string email, string datosAdicionales)
        {
            this.Nombre = nombre;
            this.Documento = documento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.IdRolEmpleado = idRolEmpleado;
            this.Email = email;
            this.DatosAdicionales = datosAdicionales;
        }

        public Obj_Empleado(int idEmpleado, string nombre, int documento, string telefono)
        {
            this.IdEmpleado = idEmpleado;
            this.Nombre = nombre;
            this.Documento = documento;
            this.Telefono = telefono;
        }

        public Obj_Empleado(int idEmpleado)
        {
            this.IdEmpleado = idEmpleado;
        }

        public Obj_Empleado(string nombre)
        {
            this.Nombre = nombre;
        }


    

        public int New_Empleado(Obj_Empleado empleado)
        {
            ConnectionDBt connection = new ConnectionDBt();

            int result;
            try
            {
                string query = $"INSERT INTO TBLEMPLEADO (strNombre,NumDocumento,StrDireccion,StrTelefono,StrEmail,IdRolEmpleado,DtmIngreso,DtmRetiro,strDatosAdicionales,DtmFechaModifica)VALUES ('{empleado.nombre}',{empleado.documento},'{empleado.direccion}','{empleado.telefono}','{empleado.email}',{empleado.idRolEmpleado},current_timestamp,current_timestamp,'{empleado.datosAdicionales}',current_timestamp);";
                result = connection.InsertUpdate(query);

                if (result == 1)
                {
                    var idEmpleado = GetEmpleadoId(empleado.Nombre);
                    //string query2 = $"INSERT INTO TBLSEGURIDAD (IdEmpleado,strusuario, strclave,DtmFechaModifica) VALUES ({idEmpleado.idEmpleado}, '','',current_timestamp);";
                    //result = connection.InsertUpdate(query2);
                    Obj_Seguridad newUsuario = new Obj_Seguridad();
                    newUsuario.IdEmpleado = idEmpleado.IdEmpleado;
                    result = newUsuario.New_Seguridad(newUsuario);
                }
                else
                {
                    result = 0;
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                result = 0;
            }
            connection.CloseConnection();
            return result;
        }


        public List<Obj_Empleado> GetEmpleadosList()
        {
            List<Obj_Empleado> list = new List<Obj_Empleado>();
            string query = "SELECT idempleado, strNombre, NumDocumento, StrTelefono FROM TBLEMPLEADO;";
            
            ConnectionDBt connection = new ConnectionDBt();
            try
            {
                var Command = connection.Consult(query);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Obj_Empleado empleado = new Obj_Empleado();

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
                Console.WriteLine(err.Message);
            }
            connection.CloseConnection();
            return list;
        }

        public Obj_Empleado GetEmpleadosForName(string nameEmpleado)
        {
            
            string query = $"SELECT idempleado, strNombre, NumDocumento, StrTelefono FROM TBLEMPLEADO WHERE strNombre = '{nameEmpleado}';";
            ConnectionDBt connection = new ConnectionDBt();
            Obj_Empleado empleado = new Obj_Empleado();

            try
            {
                var Command = connection.Consult(query);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    empleado.IdEmpleado = Reader.GetInt32(0);
                    empleado.Nombre = Reader.GetString(1);
                    empleado.Documento = Reader.GetInt32(2);
                    empleado.Telefono = Reader.GetString(3);
                }
                Reader.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            connection.CloseConnection();
            return empleado;
        }

        public Obj_Empleado GetEmpleadoId(string nombreUsuario)
        {
            Obj_Empleado empleado = new Obj_Empleado();
            string query = $"SELECT idempleado FROM TBLEMPLEADO WHERE strNombre = '{nombreUsuario}';";
            ConnectionDBt connection = new ConnectionDBt();

            try
            {
                var Command = connection.Consult(query);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {

                    empleado.IdEmpleado = Reader.GetInt32(0);


                }

                Reader.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            connection.CloseConnection();
            return empleado;
        }

        public Obj_Empleado GetDatosEmpleadoId(int idEmpleado)
        {
            Obj_Empleado empleado = new Obj_Empleado();
            Obj_Rol obj_Rol = new Obj_Rol();
            string query = $"SELECT strnombre, NumDocumento, StrTelefono, stremail, strdireccion, strdatosadicionales, idrolempleado FROM TBLEMPLEADO WHERE idempleado = {idEmpleado};";
            int idRol = 0;
            ConnectionDBt connection = new ConnectionDBt();

            try
            {
                var Command = connection.Consult(query);
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
                empleado.NombreRol = obj_Rol.GetNombreRolId(idRol).NombreRol;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            connection.CloseConnection();
            return empleado;
        }

        public int UpdateEmpleado(Obj_Empleado empleado)
        {


            ConnectionDBt connection = new ConnectionDBt();
            int result = 0;
            string query = "UPDATE TBLEMPLEADO SET StrNombre = @nombre, NumDocumento = @documento, StrTelefono =@telefono , stremail = @email, strdireccion = @direccion, idrolempleado = @idRol, strdatosadicionales = @datosAdicionales, dtmfechamodifica = current_timestamp  WHERE idempleado = @idempleado;";
            try
            {
                var Command = connection.Consult(query);

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
                                Console.WriteLine(err.Message);
            }

            connection.CloseConnection();
            return result;

        }

        public int DeleteEmpleadoForId(int idEmpleado)
        {
            string query = $"DELETE FROM TBLEMPLEADO WHERE idempleado = {idEmpleado};";
            ConnectionDBt connection = new ConnectionDBt();

            int respuesta = 0;
            try
            {
                var Command = connection.Consult(query);
                respuesta = Command.ExecuteNonQuery();

            }
            catch (Exception err)
            {
                                Console.WriteLine(err.Message);
            }
            connection.CloseConnection();
            return respuesta;
        }


    }
}
