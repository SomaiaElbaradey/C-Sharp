using Lab04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;

namespace Lab04.Controllers
{
    public class EmployeeController : Controller
    {
        MVC04_CompanyContext DB;
        public EmployeeController()
        {
            DB = new MVC04_CompanyContext();
        }

        // GET: All Employees
        public ActionResult Index()
        {
            var employees = DB.Employees.Include(employee => employee.Department).ToList();
            return View(employees);
        }

        //Post: new Employee
        [HttpGet]
        public ActionResult Create()
        {
            var departments = DB.Departments.ToList();
            ViewBag.departments = new SelectList(departments, "DeptId", "DeptName", 1);
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid == true)
            {
                DB.Employees.Add(employee);
                DB.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.departments = new SelectList(DB.Departments.ToList(), "DeptId", "DeptName", 1);
            return View();
        }

        //update: eixisting Employee
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var employee = DB.Employees.Find(id);
            ViewBag.departments = new SelectList(DB.Departments.ToList(), "DeptId", "DeptName", employee.DeptId);
            return View(employee);
        }
        [HttpPost]
        public ActionResult Edit(Employee newEmployee)
        {
            if (ModelState.IsValid)
            {
                DB.Entry(newEmployee).State = EntityState.Modified;
                DB.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.departments = new SelectList(DB.Departments.ToList(), "DeptId", "DeptName", newEmployee.DeptId);
            return View(newEmployee);
        }

        //Get: One Employee
        [HttpGet]
        public ActionResult Details(int id)
        {
            var employee = DB.Employees.Find(id);
            return View(employee);
        }

        //Delete: Employee
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var student = DB.Employees.Find(id);
            DB.Employees.Remove(student);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }

        //check if email exists
        public JsonResult EmailExists(string Email)
        {
            return Json(!DB.Employees.Any(emp => emp.Email.ToLower() == Email.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}