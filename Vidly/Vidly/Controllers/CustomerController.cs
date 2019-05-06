using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customer
        public ActionResult Index()
        {
            var customer = _context.Customers.Include(c=>c.MembershipType).ToList();
            //var viewModel = new RandomMovieViewModel
            //{
            //    Customers = customer
            //};
            return View(customer);
        }

        //private IEnumerable<Customer> GetCustomers()
        //{
        //    return new List<Customer>
        //    {

        //       new Customer { Id = 1, Name= "Customer1"},
        //       new Customer { Id = 2, Name= "Customer2"},
        //       new Customer { Id = 3, Name= "Customer3"}

        //    };

        //}

        public ActionResult Details(int id)
        {
            var selectedCustomer = _context.Customers.Include(c=>c.MembershipType).Where(w => w.Id == id).FirstOrDefault();

            return View(selectedCustomer);
        }
    }
}