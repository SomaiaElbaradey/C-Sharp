using Lab01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01.Controllers
{
    [HandleError]
    public class StudentController : Controller
    {
        ITI dataBase;
        public StudentController()
        {
            dataBase = new ITI();
        }

        // GET: Student
        [HttpGet]
        [OutputCache(Duration = 60)]
        public JsonResult GetAll()
        {
            var students = dataBase.Students.ToList();
            return Json(students, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult GetOne(int id)
        {
            var student = dataBase.Students.Find(id);
            return Json(student, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult GetByName(string name)
        {
            var student = dataBase.Students.FirstOrDefault(stud => stud.Fname == name);
            return Json(student, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public string Msg()
        {
            return "Msg";
        }

        // POST: Student
        [HttpPost]
        public void Add(Student _Student)
        {
            dataBase.Students.Add(_Student);
            dataBase.SaveChanges();
        }
        
        //PUT: Student
        [HttpPut]
        public void Update(Student _Student)
        {
            var student = dataBase.Students.FirstOrDefault(stud => stud.Id == _Student.Id);
            student.Fname = _Student.Fname;
            student.Lname = _Student.Lname;
            student.Address = _Student.Address;
            student.Age = _Student.Age;
            dataBase.SaveChanges();
        }

        //DELETE: Student
        [HttpDelete]
        public void Delete(int id)
        {
            var student = dataBase.Students.Find(id);
            dataBase.Students.Remove(student);
            dataBase.SaveChanges();
        }
    }
}