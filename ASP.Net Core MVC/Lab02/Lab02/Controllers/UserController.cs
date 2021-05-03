using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab02.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult userView()
        {
            return View();
        }
        public ActionResult myView()
        {
            return View();
        }
    }
}