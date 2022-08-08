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
            if (!IsPostBack)
            {
                MovieDbConnection movieDbConnection = new MovieDbConnection();
                DataTable dtMovies = movieDbConnection.GetAllMovie();
                gvMovieDetails.DataSource = dtMovies;
                gvMovieDetails.DataBind();
            }
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
            if (dtMovie != null && dtMovie.Rows.Count > 0)
            {

                txtMovieName.Text = dtMovie.Rows[0][1].ToString();
                txtMovieDesc.Text = dtMovie.Rows[0][2].ToString();
                txtMovieType.Text = dtMovie.Rows[0][3].ToString();
            }
            else
                lblMsg.Text = "No data Found!";


        }

        protected void txtMovieDesc_TextChanged(object sender, EventArgs e)
        {

        }

        protected void gvMovieDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            MovieDbConnection movieDbConnection = new MovieDbConnection();
            MovieData movieData = new MovieData();
            movieData.Id=Convert.ToInt32(txtMovieId.Text);
            movieData.MovieName = txtMovieName.Text;
            movieData.MovieDesc = txtMovieDesc.Text;
            movieData.MovieType = txtMovieType.Text;
            string msg = movieDbConnection.UpdateMovie(movieData);
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

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int movieId = Convert.ToInt32(txtMovieId.Text);
            MovieDbConnection movieDbConnection = new MovieDbConnection();
            MovieData movieData = new MovieData();
            movieData.Id = Convert.ToInt32(txtMovieId.Text);
            movieData.MovieName = null;
            movieData.MovieDesc = null;
            movieData.MovieType = null;
            string msg = movieDbConnection.DeleteMovieById(movieId);
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

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtMovieId.Text = "";
            txtMovieName.Text = "";
            txtMovieDesc.Text = "";
            txtMovieType.Text = "";
        }
    }
}