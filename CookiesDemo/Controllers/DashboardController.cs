using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CookiesDemo.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            HttpCookie c = Request.Cookies["UserName"];
            if(c != null)
            {
                ViewBag.Message = Request.Cookies["UserName"].Value.ToString();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}