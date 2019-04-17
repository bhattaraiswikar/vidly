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
            var customer = GetCustomers();
            //var viewModel = new RandomMovieViewModel
            //{
            //    Customers = customer
            //};
            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {

               new Customer { Id = 1, Name= "Customer1"},
               new Customer { Id = 2, Name= "Customer2"},
               new Customer { Id = 3, Name= "Customer3"}

            };

        }

        public ActionResult Details(int id)
        {
            var selectedCustomer = GetCustomers().Where(w => w.Id == id).FirstOrDefault();

            return View(selectedCustomer);
        }
    }
}