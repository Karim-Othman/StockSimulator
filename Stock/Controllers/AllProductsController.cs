using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stock.Models;

namespace Stock.Controllers
{
    public class AllProductsController : Controller
    {

        private ApplicationDbContext _context;

        public AllProductsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {
            dynamic Container = new ExpandoObject();

            var products = _context.AllProducts.ToList();
            var AgentName = System.Web.HttpContext.Current.User.Identity.Name;
            var Agent = _context.Users.SingleOrDefault(u => u.UserName == AgentName);
            var Balance = Agent.Money;

            Container.products = products;
            Container.Balance = Balance;
            return View(Container);
        }
    }
}