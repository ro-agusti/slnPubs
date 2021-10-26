using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos.Models;
using System.Data.SqlClient;
using Datos.Servidor;
using System.Data;

namespace Datos.Admin
{
    public static class AdmPublisher
    {
       public static List<Publisher> listarPublicadores()
        {
            string consultaSQL = "SELECT pub_id,pub_name,city,state,country FROM dbo.publishers";
            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.ConectarBase());
            SqlDataReader reader;
            reader = command.ExecuteReader();
            List<Publisher> publicadores = new List<Publisher>();
            while (reader.Read())
            {
                publicadores.Add(
                    new Publisher()
                    {
                        Pub_id=reader["pub_id"].ToString(),
                Pub_name = reader["pub_name"].ToString(),
                City = reader["city"].ToString(),
                State = reader["state"].ToString(),
                Country = reader["country"].ToString()

            }
                    );

            }
            reader.Close();
            AdminDB.ConectarBase().Close();
            return publicadores;
        }

        public static List<Publisher> listarPublicadores(string city)
        {
            string consultaSQL = "SELECT pub_id,pub_name,city,state,country FROM dbo.publishers where city=@city";
            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.ConectarBase());
            SqlDataReader reader;

            command.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = city;

            reader = command.ExecuteReader();
            List<Publisher> publicadores = new List<Publisher>();
            while (reader.Read())
            {
                publicadores.Add(
                    new Publisher()
                    {
                        Pub_id = reader["pub_id"].ToString(),
                        Pub_name = reader["pub_name"].ToString(),
                        City = reader["city"].ToString(),
                        State = reader["state"].ToString(),
                        Country = reader["country"].ToString()

                    }
                    );

            }
            reader.Close();
            AdminDB.ConectarBase().Close();
            return publicadores;
        }
       
        public static List<Publisher> listarPublicadores(string city, string state)
        {
            string consultaSQL = "SELECT pub_id,pub_name,city,state,country  FROM dbo.publishers WHERE city = @city AND state is null OR state = @state";
            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.ConectarBase());
            SqlDataReader reader;

            command.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = city;
            command.Parameters.Add("@state", SqlDbType.Char, 2).Value = state;

            reader = command.ExecuteReader();
            List<Publisher> publicadores = new List<Publisher>();
            while (reader.Read())
            {
                publicadores.Add(
                    new Publisher()
                    {
                        Pub_id = reader["pub_id"].ToString(),
                        Pub_name = reader["pub_name"].ToString(),
                        City = reader["city"].ToString(),
                        State = reader["state"].ToString(),
                        Country = reader["country"].ToString()

                    }
                    );

            }
            reader.Close();
            AdminDB.ConectarBase().Close();
            return publicadores;
        }

        public static List<Publisher> listarPublicadores(string city, string state, string country)
        {
            string consultaSQL = "SELECT pub_id,pub_name,city,state,country  FROM dbo.publishers WHERE city = @city AND state is null OR state = @state and country=@country";
            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.ConectarBase());
            SqlDataReader reader;

            command.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = city;
            command.Parameters.Add("@state", SqlDbType.Char, 2).Value = state;
            command.Parameters.Add("@country", SqlDbType.VarChar, 30).Value = country;

            reader = command.ExecuteReader();
            List<Publisher> publicadores = new List<Publisher>();
            while (reader.Read())
            {
                publicadores.Add(
                    new Publisher()
                    {
                        Pub_id = reader["pub_id"].ToString(),
                        Pub_name = reader["pub_name"].ToString(),
                        City = reader["city"].ToString(),
                        State = reader["state"].ToString(),
                        Country = reader["country"].ToString()

                    }
                    );

            }
            reader.Close();
            AdminDB.ConectarBase().Close();
            return publicadores;
        }
    }
}
