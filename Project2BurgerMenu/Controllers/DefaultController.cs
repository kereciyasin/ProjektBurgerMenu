using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2BurgerMenu.Entities;
using Project2BurgerMenu.Context;

namespace Project2BurgerMenu.Controllers
{
    public class DefaultController : Controller
    {
        BurgerMenuContext db = new BurgerMenuContext(); 
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {

            return PartialView();   
        }

        public PartialViewResult PartialNavBar()
        {
            return PartialView();
        }

        public PartialViewResult PartialAbout()
        {
            return PartialView();
        }
        public PartialViewResult TodaysOffer()
        {
            var deal = db.Products.Where(x => x.DealOfTheDay == true).ToList(); 
            return PartialView(deal);
        }
        public PartialViewResult PartialMenu()
        {     
            return PartialView();
        }
        public PartialViewResult PartialCategory() 
        {
            var values = db.Categories.Take(6).ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialGallery()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScripts() {
            return PartialView();
        }   
    }
}