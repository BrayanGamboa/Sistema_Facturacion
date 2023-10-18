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
    public class Obj_Rol
    {
        public Obj_Rol() { }

        private string nombreRol;
        private int idRol;
        private NpgsqlDataReader Reader;


        public string NombreRol { get => nombreRol; set => nombreRol = value; }
        public int IdRol { get => idRol; set => idRol = value; }

        public Obj_Rol(string nombreRol)
        {
            this.NombreRol = nombreRol;
        }


        public Obj_Rol(int idRol, string nombreRol)
        {
            this.NombreRol = nombreRol;
            this.IdRol = idRol;

        }
        public Obj_Rol(int idRol)
        {
            this.IdRol = idRol;
        }

        public int New_Rol(Obj_Rol rol)
        {
            ConnectionDBt connection = new ConnectionDBt();
            int result = 0;
            try
            {
                string query = $"INSERT INTO TBLROLES (StrDescripcion)VALUES ({rol.NombreRol});";
                result = connection.InsertUpdate(query);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            connection.CloseConnection();

            return result;
        }
        public List<Obj_Rol> GetRolList()
        {
            List<Obj_Rol> list = new List<Obj_Rol>();
            string query = "SELECT * FROM TBLROLES;";
            ConnectionDBt connection = new ConnectionDBt();

            try
            {
                var Command = connection.Consult(query);
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
                Console.WriteLine(err.Message);
            }
            connection.CloseConnection();
            return list;
        }
     
        public Obj_Rol GetRolId(string nombreRol)
        {
            Obj_Rol rol = new Obj_Rol();
            string query = $"SELECT idrolempleado, StrDescripcion FROM TBLROLES WHERE strdescripcion = '{nombreRol}';";
            ConnectionDBt connection = new ConnectionDBt();

            try
            {
                var Command = connection.Consult(query);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    rol.IdRol = Reader.GetInt32(0);
                    rol.NombreRol = Reader.GetString(1);

                }
                Reader.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            connection.CloseConnection();
            return rol;
        }

        public Obj_Rol GetNombreRolId(int idRol)
        {
            Obj_Rol rol = new Obj_Rol();
            string query = $"SELECT strdescripcion FROM TBLROLES WHERE  idrolempleado = {idRol};";
            ConnectionDBt connection = new ConnectionDBt();

            try
            {
                var Command = connection.Consult(query);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    rol.NombreRol = Reader.GetString(0);
                }
                Reader.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            connection.CloseConnection();
            return rol;
        }       

        public int UpdateRol(Obj_Rol obj_Rol)
        {
            ConnectionDBt connection = new ConnectionDBt();

            int result = 0;
            string query = $"UPDATE TBLROLES SET strdescripcion = '{obj_Rol.nombreRol}' WHERE idrolempleado = {obj_Rol.idRol};";
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

        public int DeleteRolForId(int idRol)
        {
            string query = $"DELETE FROM TBLROLES WHERE idrolempleado = {idRol};";
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
