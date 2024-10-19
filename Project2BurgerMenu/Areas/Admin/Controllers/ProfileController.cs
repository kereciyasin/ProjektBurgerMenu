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
        [HttpGet]
        public ActionResult MyProfileList()
        {
            var userName = Session["X"]; 
            var values = db.Admins.Where(x => x.Username == userName).FirstOrDefault(); 
            return View(values);
        }
        [HttpPost]  
        public ActionResult MyProfileList(Project2BurgerMenu.Entities.Admin admin)
        {
            var value = Session["X"];
            var values = db.Admins.Where(x => x.Username == value.ToString()).FirstOrDefault();
            values.Name = admin.Name;
            values.Surname = admin.Surname;
            values.Username = admin.Username;
            values.Password = admin.Password;
            values.Email = admin.Email;
            db.SaveChanges();
            return RedirectToAction("Index", "Login");   

        }
    }
}