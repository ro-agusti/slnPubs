using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos.Servidor;
using Datos.Models;
using System.Data.SqlClient;
using System.Data;

namespace Datos.Admin
{
    public static class AdmAuthor
    {
        public static List<Author> listar()
        {
            string consultaSQL = "SELECT au_id,au_lname,au_fname,phone,address,city,state,zip,contract FROM dbo.authors";
            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.ConectarBase());
            SqlDataReader reader;
            reader = command.ExecuteReader();
            List<Author> autores = new List<Author>();
            while (reader.Read())
            {
                autores.Add(
                    new Author()
                    {
                        //,,,,,,,,contract
                        Au_id=reader["au_id"].ToString(),
                        Au_lname = reader["au_lname"].ToString(),
                        Au_fname = reader["au_fname"].ToString(),
                        Phone = reader["phone"].ToString(),
                        Address = reader["address"].ToString(),
                        City = reader["city"].ToString(),
                        State = reader["state"].ToString(),
                        Zip = reader["zip"].ToString(),
                        Contract =Convert.ToBoolean(reader["contract"]),
                    }
                    );
            }
            reader.Close();
            AdminDB.ConectarBase().Close();
            return autores;
        }

        public static List<Author> listar(string city)
        {
            string consultaSQL = "SELECT au_id,au_lname,au_fname,phone,address,city,state,zip,contract FROM dbo.authors where city = @city";

            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.ConectarBase());
            SqlDataReader reader;

            command.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = city;

            reader = command.ExecuteReader();
            List<Author> autores = new List<Author>();
            while (reader.Read())
            {
                autores.Add(
                    new Author()
                    {
                        Au_id = reader["au_id"].ToString(),
                        Au_lname = reader["au_lname"].ToString(),
                        Au_fname = reader["au_fname"].ToString(),
                        Phone = reader["phone"].ToString(),
                        Address = reader["address"].ToString(),
                        City = reader["city"].ToString(),
                        State = reader["state"].ToString(),
                        Zip = reader["zip"].ToString(),
                        Contract = Convert.ToBoolean(reader["contract"]),
                    }
                    );
            }
            reader.Close();
            AdminDB.ConectarBase().Close();
            return autores;
        }

        public static List<Author> listar(string city, string state)
        {
            string consultaSQL = "SELECT au_id,au_lname,au_fname,phone,address,city,state,zip,contract FROM dbo.authors where city = @city and state = @state";

            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.ConectarBase());
            SqlDataReader reader;

            command.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = city;

            command.Parameters.Add("@state", SqlDbType.Char, 2).Value = state;

            reader = command.ExecuteReader();
            List<Author> autores = new List<Author>();
            while (reader.Read())
            {
                autores.Add(
                    new Author()
                    {
                        Au_id = reader["au_id"].ToString(),
                        Au_lname = reader["au_lname"].ToString(),
                        Au_fname = reader["au_fname"].ToString(),
                        Phone = reader["phone"].ToString(),
                        Address = reader["address"].ToString(),
                        City = reader["city"].ToString(),
                        State = reader["state"].ToString(),
                        Zip = reader["zip"].ToString(),
                        Contract = Convert.ToBoolean(reader["contract"]),
                    }
                    );
            }
            reader.Close();
            AdminDB.ConectarBase().Close();
            return autores;
        }

        public static DataTable listarSoloCiudades()
        {
            string consultaSQL = "select distinct city from authors";

            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, AdminDB.ConectarBase());

            DataSet ds = new DataSet();

            adapter.Fill(ds, "City");

            return ds.Tables["City"];
        }

        public static DataTable listarDT (string ciudad)
        {
            string consultaSQL = "SELECT au_id,au_lname,au_fname,phone,address,city,state,zip,contract FROM dbo.authors where city = @city";

            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, AdminDB.ConectarBase());

                             adapter.SelectCommand.Parameters.Add("@city", SqlDbType.VarChar,20).Value = ciudad;

            DataSet ds = new DataSet();

            adapter.Fill(ds, "City");

            return ds.Tables["City"];
        }
    }
}
