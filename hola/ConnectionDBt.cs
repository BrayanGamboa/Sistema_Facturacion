using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Collections;


namespace Capa_Acceso_De_Datos
{
    public class ConnectionDBt
    {
        

        private NpgsqlCommand Command;
        private NpgsqlDataReader Reader;
        private NpgsqlConnection Connection;

        public ConnectionDBt() { }

        private static string getChainDB()
        {
            string host_DB = "";
            string port_DB = "";
            string name_DB = "";
            string user_DB = "";
            string passwod_DB = "";

            string chainConnection = string.Format($"Host={host_DB};Port={port_DB};Database={name_DB};UserName={user_DB};Password={passwod_DB};");

            return chainConnection;
        }

        public void CreateConnection()
        {
            try
            {
                Connection = new NpgsqlConnection(getChainDB());
                Connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void CloseConnection()
        {
            try
            {
                Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public NpgsqlCommand Consult(string query)
        {
            CreateConnection();
            Command = new NpgsqlCommand(query, Connection);                                    
            return Command;
        }


        public int InsertUpdate(string query)
        {
            int result;
            CreateConnection();
            Command = new NpgsqlCommand(query, Connection);
            result = Command.ExecuteNonQuery();
            CloseConnection();
            return result;
        }






    }
}
