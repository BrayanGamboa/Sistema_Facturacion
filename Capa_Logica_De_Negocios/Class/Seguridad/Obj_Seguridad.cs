using Capa_Acceso_De_Datos;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica_De_Negocios.Class
{
    public class Obj_Seguridad
    {
        private int idEmpleado, idSeguridad;
        private string nombreUsuario, contrasena, nombreUsuarioModifica, nombreEmpleado;
        private NpgsqlDataReader Reader;


        public Obj_Seguridad() { }

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string NombreUsuarioModifica { get => nombreUsuarioModifica; set => nombreUsuarioModifica = value; }
        public int IdSeguridad { get => idSeguridad; set => idSeguridad = value; }
        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }

        public Obj_Seguridad(int idEmpleado, string nombreUsuario, string contrasena, string nombreUsuarioModifica)
        {
            this.IdEmpleado = idEmpleado;
            this.NombreUsuario = nombreUsuario;
            this.Contrasena = contrasena;
            this.NombreUsuarioModifica = nombreUsuarioModifica;
        }

        public Obj_Seguridad(string nombreEmpleado, string nombreUsuario, string contrasena, int idSeguridad)
        {
            this.NombreUsuario = nombreUsuario;
            this.Contrasena = contrasena;
            this.NombreEmpleado = nombreEmpleado;
            this.IdSeguridad = idSeguridad;
        }

        public Obj_Seguridad(string nombreUsuario, string contrasena)
        {
            this.NombreUsuario = nombreUsuario;
            this.Contrasena = contrasena;
        }

        public Obj_Seguridad(int idEmpleado)
        {
            this.IdEmpleado = idEmpleado;
        }

        //Seguridad
        public int New_Seguridad(Obj_Seguridad seguridad)
        {
            ConnectionDBt connection = new ConnectionDBt();
            int result;
            try
            {
                string query = "";
                if (string.IsNullOrEmpty(seguridad.NombreUsuario) || string.IsNullOrEmpty(seguridad.Contrasena))
                {
                    query = $"INSERT INTO TBLSEGURIDAD (IdEmpleado,StrUsuario,StrClave,DtmFechaModifica )VALUES ({seguridad.IdEmpleado},'','',current_timestamp);";
                }
                else
                {
                    query = $"INSERT INTO TBLSEGURIDAD (IdEmpleado,StrUsuario,StrClave,DtmFechaModifica )VALUES ({seguridad.IdEmpleado},'{seguridad.NombreUsuario}',{seguridad.Contrasena},current_timestamp);";
                }
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

        public List<Obj_Seguridad> GetSeguridadList()
        {
            List<Obj_Seguridad> list = new List<Obj_Seguridad>();
            string query = "SELECT TBLSEGURIDAD.IdSeguridad, TBLEMPLEADO.strNombre, TBLSEGURIDAD.StrUsuario, TBLSEGURIDAD.StrClave FROM TBLSEGURIDAD JOIN TBLEMPLEADO ON TBLSEGURIDAD.IdEmpleado = TBLEMPLEADO.IdEmpleado;";
            ConnectionDBt connection = new ConnectionDBt();

            try
            {
                var Command = connection.Consult(query);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Obj_Seguridad seguridad = new Obj_Seguridad();
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
                Console.WriteLine(err.Message);
            }
            connection.CloseConnection();
            return list;
        }

        public Obj_Seguridad GetCredenciales(string nombre)
        {
            string query = $"SELECT TBLSEGURIDAD.StrUsuario, TBLSEGURIDAD.StrClave FROM TBLSEGURIDAD JOIN TBLEMPLEADO ON TBLEMPLEADO.IdEmpleado = TBLSEGURIDAD.IdEmpleado WHERE strNombre = '{nombre}';";
            ConnectionDBt connection = new ConnectionDBt();
            Obj_Seguridad credenciales = new Obj_Seguridad();

            try
            {
                var Command = connection.Consult(query);
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
                Console.WriteLine(err.Message);
            }
            connection.CloseConnection();
            return credenciales;
        }

        public Obj_Empleado GetNombre(string nombre)
        {
            string query = $"SELECT TBLEMPLEADO.strNombre FROM TBLSEGURIDAD JOIN TBLEMPLEADO ON TBLEMPLEADO.IdEmpleado = TBLSEGURIDAD.IdEmpleado WHERE StrUsuario = '{nombre}';";
            ConnectionDBt connection = new ConnectionDBt();

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
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            connection.CloseConnection();
            return empleado;
        }

        public Obj_Empleado GetId(string nombre)
        {
            string query = $"SELECT IdEmpleado WHERE StrUsuario = '{nombre}';";
            ConnectionDBt connection = new ConnectionDBt();

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
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            connection.CloseConnection();
            return empleado;
        }
    }

}

