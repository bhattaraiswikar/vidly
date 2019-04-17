using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customer = new List<Customer>
            {
               new Customer { Id = 1, Name= "Customer1"},
               new Customer { Id = 2, Name= "Customer2"},
               new Customer { Id = 3, Name= "Customer3"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Customers = customer
            };
            return View(viewModel);
        }
    }
}