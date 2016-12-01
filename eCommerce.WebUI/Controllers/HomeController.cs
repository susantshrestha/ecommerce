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

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
