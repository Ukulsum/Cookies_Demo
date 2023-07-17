using CookiesDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CookiesDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(User users)
        {
            if(ModelState.IsValid == true)
            {
                HttpCookie cookie = new HttpCookie("UserName");
                cookie.Value = users.UserName;

                HttpContext.Response.Cookies.Add(cookie);
                cookie.Expires = DateTime.Now.AddDays(2);
                return RedirectToAction("Index", "Dashboard");
            }
            return View();
        }
    }
}