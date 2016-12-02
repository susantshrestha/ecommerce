using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ecommerce.Contracts.Repositories;
using Ecommerce.Models;

namespace eCommerce.WebUI.Controllers
{
    public class AdminController : Controller
    {
        IRepositoryBase customers;
        IRepositoryBase products;

        public AdminController(IRepositoryBase customers, IRepositoryBase products)
        {
            this.customers = customers;
            this.products = products;
        }

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            var productlist = products.GetById(id);
            return View(productlist);
        }

        public ActionResult ProductList()
        {
            var model = products.GetAll();
            return View(model);
        }

        public ActionResult CreateProduct()
        {
            var model = new Product();

            return View(model);
        }

        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {
            products.Insert(product);
            products.Save();

            return RedirectToAction("ProductList");
        }

        public ActionResult EditProduct(int id)
        {
            var model = products.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult EditProduct(Product product)
        {
            products.Update(product);
            products.Save();
            return RedirectToAction("ProductList");
        }

        // GET: Home/Delete/5
        public ActionResult DeleteProduct(int id)
        {
            var model = products.GetById(id);
            return View(model);
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult DeleteProduct(Product product)
        {
            products.Delete(product);
            products.Save();
            return RedirectToAction("ProductList");
            
            
        }

    }
}