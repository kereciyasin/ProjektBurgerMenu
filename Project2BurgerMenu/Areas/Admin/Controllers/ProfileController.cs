using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2BurgerMenu.Context;
using Project2BurgerMenu.Entities;


namespace Project2BurgerMenu.Areas.Admin.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        // GET: Admin/Profile
        BurgerMenuContext db = new BurgerMenuContext(); 
        public ActionResult MyProfileList()
        {
            var userName = Session["X"]; 
            var values = db.Admins.Where(x => x.Username == userName).FirstOrDefault(); 
            return View(values);
        }
    }
}