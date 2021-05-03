using Lab03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Lab03.Controllers
{
    public class StudentController : Controller
    {
        InstitutionContext Db;
        public StudentController()
        {
            Db = new InstitutionContext();
        }
        // GET: Student
        [HttpGet]
        public ActionResult Index()
        {
            var students = Db.Students.Include(s01 => s01.Department).ToList();
            return View(students);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult CreateConfirmed(Student student)
        {
            Db.Students.Add(student);
            Db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}