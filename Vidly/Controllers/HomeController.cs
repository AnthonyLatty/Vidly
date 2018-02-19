using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Customer()
        {
            var customers = new List<Customer>
            {
                new Customer {Name = "John Doe"},
                new Customer {Name = "Marc Latty"},
                new Customer {Name = "John Brown"},
                new Customer {Name = "Peter Pam"},
                new Customer {Name = "Pam Manning"},
                new Customer {Name = "Matthew Peet"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Movie()
        {
            var movie = new List<Movie>
            {
                new Movie {Name = "Shrek"},
                new Movie {Name = "Shrek 2"},
                new Movie {Name = "Iron Man"},
                new Movie {Name = "Flash"},
                new Movie {Name = "God is not dead"},
                new Movie {Name = "Shrek 3"}

            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie
            };

            return View(viewModel);
        }
    }
}