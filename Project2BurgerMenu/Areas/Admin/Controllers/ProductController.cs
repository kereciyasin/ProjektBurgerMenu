using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2BurgerMenu.Entities;
using Project2BurgerMenu.Context;
using System.Data.Entity;

namespace Project2BurgerMenu.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        BurgerMenuContext db = new BurgerMenuContext();
        public ActionResult ProductList()
        {
            var products = db.Products
                        .Include(p => p.Category)
                        .ToList();

            return View(products);

        }
        [HttpGet]
        public ActionResult CreateProduct()
        {
            List<SelectListItem> values = (from x in db.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("ProductList");
        }
    }
}