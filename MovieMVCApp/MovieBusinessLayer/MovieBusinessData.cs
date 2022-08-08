using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MovieDataLayer;

namespace MovieBusinessLayer
{
    public class MovieBusinessData
    {
        public string InsertMovie(Movie movie)
        {
            MovieDbConnection movieDbConnection = new MovieDbConnection();
            string msg = movieDbConnection.InsertMovie(movie);
            return msg;
        }
        public string DeleteMovie(int movieId)
        {
            MovieDbConnection movieDbConnection = new MovieDbConnection();
            string msg = movieDbConnection.DeleteMovie(movieId);
            return msg;
            
        }
        public string UpdateMovie(Movie movie)
        {
            MovieDbConnection movieDbConnection = new MovieDbConnection();
            string msg = movieDbConnection.UpdateMovie(movie);
            return msg;
        }
        public Movie GetMovieById(int movieId)
        {
           
            MovieDbConnection movieDbConnection = new MovieDbConnection();
            Movie movie = movieDbConnection.GetMovieById(movieId);
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            MovieDbConnection movieDbConnection=new MovieDbConnection();
            List<Movie> movies = movieDbConnection.GetMovies();
            return movies;
        }
    }
}
