using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;

namespace MovieDataLayer
{
    public class MovieDbConnection
    {
        MyMovieDbEntities1 myMovieDbEntities1 = new MyMovieDbEntities1();
        public string InsertMovie(Movie movie)
        {
            myMovieDbEntities1.Movies.Add(movie);//insert into movies values(movies.id,..)
            myMovieDbEntities1.SaveChanges();//execute stmt
            return "Inserted";
        }
        public string DeleteMovie(int  movieId)
        {
            Movie movie = myMovieDbEntities1.Movies.Find(movieId);//select * from movies where id=movieId
            myMovieDbEntities1.Movies.Remove(movie);//delete from movie where id=movieId
            myMovieDbEntities1.SaveChanges();
            return "Deleted";
        }
        public string UpdateMovie(Movie movie)
        {
            myMovieDbEntities1.Entry(movie).State = EntityState.Modified;
            myMovieDbEntities1.SaveChanges();
            return "Updated";
        }
        public Movie GetMovieById(int movieId)
        {
            Movie movie=myMovieDbEntities1.Movies.Find(movieId);
            return movie;
        }
        public List<Movie> GetMovies()
        {
            List<Movie> movies = myMovieDbEntities1.Movies.ToList();
            return movies;
        }
    }
}
