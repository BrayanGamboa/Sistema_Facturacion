using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Capa_Acceso_De_Datos;
using Npgsql;

namespace Capa_Logica_De_Negocios
{
    public class Obj_Login
    {
        private string usuario, contrasena;
        private int idCredenciales, idEmpleado;        
        private NpgsqlDataReader Reader;
        

        public Obj_Login() { }

        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }

        public int IdCredenciales { get => idCredenciales; set => idCredenciales = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }

        public Obj_Login(string usuario, string contrasena)
        {
            this.Usuario = usuario;
            this.Contrasena = contrasena;
        }

        public Obj_Login(int idCredenciales, string usuario, string contrasena, int idEmpleado = 0)
        {
            this.IdCredenciales = idCredenciales;
            this.Usuario = usuario;
            this.Contrasena = contrasena;
            this.IdEmpleado = idEmpleado;
        }

        public int ValidarCredenciales(Obj_Login login)
        {
            ConnectionDBt connection = new ConnectionDBt();
            Obj_Login credencialesValidacion = new Obj_Login();
            string query = $"SELECT StrUsuario, StrClave FROM TBLSEGURIDAD WHERE StrUsuario = '{login.Usuario}';";
            try
            {
                var Command = connection.Consult(query);
                Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    credencialesValidacion.Usuario = Reader.GetString(0);
                    credencialesValidacion.Contrasena = Reader.GetString(1);
                }
                Reader.Close();

                connection.CloseConnection();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            if (login.Usuario == credencialesValidacion.Usuario || login.Contrasena == credencialesValidacion.Contrasena)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public Obj_Empleado GetNombre(string nombre)
        {
            ConnectionDBt connection = new ConnectionDBt();
            string query = $"SELECT TBLEMPLEADO.strNombre FROM TBLSEGURIDAD JOIN TBLEMPLEADO ON TBLEMPLEADO.IdEmpleado = TBLSEGURIDAD.IdEmpleado WHERE StrUsuario = '{nombre}';";


            Obj_Empleado empleado = new Obj_Empleado();

            try
            {
                var Command = connection.Consult(query);
                Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    empleado.Nombre = Reader.GetString(0);
                }
                Reader.Close();
                connection.CloseConnection();

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            return empleado;
        }

        public int UpdateCredenciales(Obj_Login cliente)
        {
            ConnectionDBt connection = new ConnectionDBt();
            int result = 0;
            string query = $"UPDATE TBLSEGURIDAD SET StrUsuario = '{cliente.Usuario}', StrClave = '{cliente.Contrasena}', dtmfechamodifica = current_timestamp  WHERE idempleado = {cliente.IdEmpleado};";
            try
           {                              
                result = connection.InsertUpdate(query);                
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            connection.CloseConnection();
            return result;

        }

    }
}
