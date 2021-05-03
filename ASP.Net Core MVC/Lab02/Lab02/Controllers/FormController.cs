using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab02.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FormResult(FormCollection collection, HttpPostedFileBase myfile)
        {
            if (myfile != null)
                myfile.SaveAs(Server.MapPath($"~/Resources/{myfile.FileName}"));

            ViewBag.form = collection;

            return View();
        }
        public ActionResult Form()
        {
            return View();
        }
    }
}