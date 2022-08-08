using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace MovieWebApp
{
    public class MovieDbConnection
    {
        public static string sqlCon = @"Data Source=WKS61641\SQLEXPRESS;Initial Catalog=MyMovieDb;Integrated Security=True";

       public string InsertMovie(MovieData movieData)
        {
            string msg = string.Empty;
            SqlConnection con = new SqlConnection(sqlCon);

            string query1 = "insert into movie values('"+movieData.MovieName+"','"+movieData.MovieDesc+"','"+movieData.MovieType+"')";
            SqlCommand cmd = new SqlCommand(query1,con);
            con.Open();
            int result=cmd.ExecuteNonQuery();
            con.Close();
            if (result != 0)
                msg = "Inserted";
            return msg;
        }
        public string UpdateMovie(MovieData movieData)
        {
            string msg = string.Empty;
            SqlConnection con = new SqlConnection(sqlCon);

            string query1 = "update movie set MovieName= '" + movieData.MovieName + "',MovieDesc='"  + movieData.MovieDesc + "', MovieType='" + movieData.MovieType + "' where id="+movieData.Id+"";
            SqlCommand cmd = new SqlCommand(query1, con);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            if (result != 0)
                msg = "Deleted";
            return msg;
        }
        public DataTable GetMovieById(int movieId)
        {
            DataTable dtMovie = new DataTable();
            SqlConnection con = new SqlConnection(sqlCon);

            string query1 = "select * from movie where id="+ movieId;
            SqlCommand cmd = new SqlCommand(query1, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            dtMovie.Load(reader);
            con.Close();
      
            return dtMovie;
        }
        public string DeleteMovieById(int movieId)
        {
            string msg = string.Empty;
            SqlConnection con = new SqlConnection(sqlCon);

            string query1 = "delete from movie where id=" + movieId;
            SqlCommand cmd = new SqlCommand(query1, con);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            if (result != 0)
                msg = "Deleted";
            return msg;
        }
        public DataTable GetAllMovie()
        {
            DataTable dtMovie = new DataTable();
            SqlConnection con = new SqlConnection(sqlCon);

            string query1 = "select * from movie";
            SqlCommand cmd = new SqlCommand(query1, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            dtMovie.Load(reader);
            con.Close();

            return dtMovie;
        }
    }

    public class MovieData
    {
        public int Id { get; set; }
        public string   MovieName { get; set; }
        public string MovieDesc { get; set; }
        public string MovieType { get; set; }
        
    }
}