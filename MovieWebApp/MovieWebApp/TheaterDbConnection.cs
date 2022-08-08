using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace MovieWebApp
{
    public class TheaterDbConnection
    {
        public static string sqlCon = @"Data Source=WKS61641\SQLEXPRESS;Initial Catalog=MyMovieDb;Integrated Security=True";

        public string InsertTheater(TheaterData theaterData)
        {
            string msg = string.Empty;
            SqlConnection con = new SqlConnection(sqlCon);

            string query1 = "insert into theater values('" + theaterData.TheaterName + "','" + theaterData.TheaterDesc + "','" + theaterData.TheaterType + "')";
            SqlCommand cmd = new SqlCommand(query1, con);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            if (result != 0)
                msg = "Inserted";
            return msg;
        }
        public string UpdateTheater(TheaterData theaterData)
        {
            string msg = string.Empty;
            SqlConnection con = new SqlConnection(sqlCon);

            string query1 = "update theater set TheaterName= '" + theaterData.TheaterName + "',TheaterDesc='" + theaterData.TheaterDesc + "', TheaterType='" + theaterData.TheaterType + "' where id=" + theaterData.Id + "";
            SqlCommand cmd = new SqlCommand(query1, con);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            if (result != 0)
                msg = "Deleted";
            return msg;
        }
        public DataTable GetTheaterById(int theaterId)
        {
            DataTable dtTheater = new DataTable();
            SqlConnection con = new SqlConnection(sqlCon);

            string query1 = "select * from theater where id=" + theaterId;
            SqlCommand cmd = new SqlCommand(query1, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            dtTheater.Load(reader);
            con.Close();

            return dtTheater;
        }
        public string DeleteTheaterById(int theaterId)
        {
            string msg = string.Empty;
            SqlConnection con = new SqlConnection(sqlCon);

            string query1 = "delete from theater where id=" + theaterId;
            SqlCommand cmd = new SqlCommand(query1, con);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            if (result != 0)
                msg = "Deleted";
            return msg;
        }
        public DataTable GetAllTheater()
        {
            DataTable dtTheater = new DataTable();
            SqlConnection con = new SqlConnection(sqlCon);

            string query1 = "select * from theater";
            SqlCommand cmd = new SqlCommand(query1, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            dtTheater.Load(reader);
            con.Close();

            return dtTheater;
        }

       

    }
    public class TheaterData
    {
        public int Id { get; set; }
        public string TheaterName { get; set; }
        public string TheaterDesc { get; set; }
        public string TheaterType { get; set; }

    }

}