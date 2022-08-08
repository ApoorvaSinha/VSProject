using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieBusinessLayer;
//Routing
//http://localhost:3432/Movie/InsertMovie
namespace MovieMVCApp.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            MovieBusinessData movieBusinessData = new MovieBusinessData();
            var result = movieBusinessData.GetAllMovies();
            return View(result);
        }
        public ActionResult InsertMovie()
        {
            return View(); //.cshtml
        }
        public ActionResult UpdateMovie()
        {
            return View(); //.cshtml
        }
        public ActionResult DeleteMovie()
        {
            return View(); //.cshtml
        }

    }
}