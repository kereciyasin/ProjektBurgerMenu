using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2BurgerMenu.Context;

namespace Project2BurgerMenu.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        BurgerMenuContext db = new BurgerMenuContext(); 
        public ActionResult ProductList()
        {
            var productList = db.Products.ToList();
            return View(productList);
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Entities.Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("ProductList");
        }
    }
}