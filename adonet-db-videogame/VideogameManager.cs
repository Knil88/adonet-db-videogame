using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace adonet_db_videogame
{
    public static class VideogameManager
    {
        private static string connessione = "Data Source=localhost;Initial Catalog=prova;Integrated Security=True";

        public static void InserisciVideogame(Videogame videogame)
        {
            SqlConnection connesioneSql = new SqlConnection(connessione);

            connesioneSql.Open();

            string query = "INSERT INTO videogames VALUES(name,overview,release_date,created_at,updated_at,software_house_id)";

            SqlCommand cmd = new SqlCommand(query, connesioneSql);
            SqlParameter sqlParameter = cmd.Parameters.Add(new SqlParameter("name", "Valore"));
            cmd.Parameters.Add(sqlParameter);

            int affectedRows = cmd.EndExecuteNonQuery();

            connesioneSql.Close();
        }
        
    }
}
