using Project2BurgerMenu.Context;
using Project2BurgerMenu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Project2BurgerMenu.Controllers
{
    public class LoginController : Controller
    {
        BurgerMenuContext db = new BurgerMenuContext();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            /* Admin tablosundaki sartlari karsiliyorsa  */
            var values = db.Admins.FirstOrDefault(x => x.Username == admin.Username && x.Password == admin.Password);
            if (values != null)
            {
                /* Tarayiciya kayit edilmesin diyorsak false, kayit edilsin diyorsak true */
                FormsAuthentication.SetAuthCookie(values.Username, false);
                Session["Username"] = values.Username.ToString();
                /* Index acilsin product kontrollardaki buda admin icinde */
                return RedirectToAction("Index", "Product", "Admin");

            }
            else
            {
                ViewBag.ErrorMessage = "Kullanıcı adı veya şifre hatal��!";
                return View();
            }

        }
    }
}