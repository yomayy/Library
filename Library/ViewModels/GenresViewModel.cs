using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Library.Models;

namespace Library.ViewModels
{
    class GenresViewModel : DbContext
    {
        public List<Genre> genres { get; set; }

        public GenresViewModel()
        {
            genres = new List<Genre>();
            LoadGenres();
        }

        public void LoadGenres()
        {
            conn.Open();
            string query = "SELECT * FROM Genres ORDER BY Id";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            genres.Clear();
            while(reader.Read())
            {
                genres.Add(new Genre()
                {
                    Id = (int)reader["Id"],
                    Name = reader["Name"].ToString()
                });
            }

            conn.Close();
        }

        public void AddGenre(string name)
        {
            conn.Open();
            string query = @"INSERT INTO Genres (Name) VALUES (@name)";
            SqlParameter p = new SqlParameter()
            {
                ParameterName = "@name",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = name
            };
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add(p);

            conn.Close();
        }
    }
}
