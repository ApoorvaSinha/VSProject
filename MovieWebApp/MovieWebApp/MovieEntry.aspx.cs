using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MovieWebApp
{
    public partial class MovieEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            MovieDbConnection movieDbConnection = new MovieDbConnection();
            MovieData movieData = new MovieData();
            movieData.MovieName = txtMovieName.Text;
            movieData.MovieDesc = txtMovieDesc.Text;
            movieData.MovieType = txtMovieType.Text;
            string msg = movieDbConnection.InsertMovie(movieData);
            if (msg != "")
            {
                lblMsg.Text = msg;
                DataTable dtMovies = movieDbConnection.GetAllMovie();
                gvMovieDetails.DataSource = dtMovies;
                gvMovieDetails.DataBind();
            }
            else
                lblMsg.Text = "Failed";
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            int movieId = Convert.ToInt32(txtMovieId.Text);
            MovieDbConnection movieDbConnection = new MovieDbConnection();
            DataTable dtMovie=movieDbConnection.GetMovieById(movieId);

        }

        protected void txtMovieDesc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}