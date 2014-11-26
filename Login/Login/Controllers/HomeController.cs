using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/


        [Authorize]
        public ActionResult Index()
        {
            ViewBag.Message = "This can be viewed only by authenticated users only";
            // return RedirectToAction("Login", "Account");
            return View();
        }

       /* [Authorize(Roles = "admin")]
        public ActionResult AdminIndex()
        {
            ViewBag.Message = "This can be viewed only by users in Admin role only";
            return View();
        }*/

       

    }
}
