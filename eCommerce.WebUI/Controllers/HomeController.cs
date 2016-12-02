using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ecommerce.Contracts.Repositories;
using Ecommerce.DAL.Data;
using Ecommerce.DAL.Repositories;
using Ecommerce.Models;

namespace eCommerce.WebUI.Controllers
{
    
    public class HomeController : Controller
    {
        IRepositoryBase customers;
        IRepositoryBase products;

        public HomeController(IRepositoryBase customers,IRepositoryBase products)
        {
            this.customers = customers;
            this.products = products;
        }
       
        // GET: Home
        public ActionResult Index()
        {

            var productlist = products.GetAll();
            return View(productlist);
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            var productlist = products.GetById(id);
            return View(productlist);
        }

    }
}
