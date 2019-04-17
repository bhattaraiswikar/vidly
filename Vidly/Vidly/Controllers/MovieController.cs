using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        public ViewResult Index()
        {
            var movie = GetMovies();
            return View(movie);
        }
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new List<Movie>
            {
                new Movie{ Id = 1, Name = "Shrek!"},
                new Movie{ Id = 2, Name = "Batman"},
                new Movie{ Id = 3, Name = "Superman"},
                new Movie{ Id = 4, Name = "Spiderman"}
            };
            var viewModel = new RandomMovieViewModel
            {
                 Movies = movie
            };
            return View(viewModel);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie{ Id = 1, Name = "Shrek!"},
                new Movie{ Id = 2, Name = "Batman"},
                new Movie{ Id = 3, Name = "Superman"},
                new Movie{ Id = 4, Name = "Spiderman"}
            };
        }

        public ViewResult Details(int id)
        {
            var selectedMovie = GetMovies().Where(w => w.Id == id).FirstOrDefault();

                return View(selectedMovie);
        }

    }
}