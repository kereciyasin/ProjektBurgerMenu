using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2BurgerMenu.Context;

namespace Project2BurgerMenu.Areas
{
    public class CategoryController : Controller
    {
        BurgerMenuContext db = new BurgerMenuContext();
        
        public ActionResult CategoryList()
        {
            var values = db.Categories.ToList();    
            return View(values);
        }
    }
}