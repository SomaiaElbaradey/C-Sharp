using Lab05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;

namespace Lab05.Controllers
{
    public class EmployeeController : Controller
    {
        MVC05_CompanyContext DB;
        public EmployeeController()
        {
            DB = new MVC05_CompanyContext();
        }

        public ActionResult Index()
        {
            ViewBag.departments = new SelectList(DB.Departments.ToList(), "DeptId", "DeptName", 1);
            return View();
        }

        // GET: All Employees
        public ActionResult GetAll()
        {
            var employees = DB.Employees.Include(employee => employee.Department).ToList();
            return PartialView(employees);
        }

        // POST: New Employee
        //[HttpGet]
        //public ActionResult Create()
        //{
        //    ModelState.Clear();
        //    Employee employee = new Employee()
        //    {
        //        FName = string.Empty,
        //        Email = string.Empty,
        //        DeptId = 1,
        //        Address = string.Empty
        //    };
        //    ViewBag.departments = new SelectList(DB.Departments.ToList(), "DeptId", "DeptName");
        //    return PartialView(employee);
        //}

        [HttpPost]
        public ActionResult Create(Employee newEmployee)
        {
            if (ModelState.IsValid)
            {
                DB.Employees.Add(newEmployee);
                DB.SaveChanges();
                return PartialView("GetAll", DB.Employees.Include(emp => emp.Department).ToList());
            }
            ViewBag.departments = new SelectList(DB.Departments.ToList(), "DeptId", "DeptName", 1);
            return PartialView();
        }

        //Delete: Employee
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var employee = DB.Employees.Find(id);
            DB.Employees.Remove(employee);
            DB.SaveChanges();
            return PartialView("GetAll", DB.Employees.Include(emp => emp.Department).ToList());
        }

        //update: eixisting Employee
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var employee = DB.Employees.Find(id);
            ViewBag.departments = new SelectList(DB.Departments.ToList(), "DeptId", "DeptName", employee.DeptId);
            return PartialView(employee);
        }

        //[HttpPost]
        public ActionResult Edit(Employee modifiedEmployee)
        {
            if (ModelState.IsValid)
            {
                DB.Entry(modifiedEmployee).State = EntityState.Modified;
                DB.SaveChanges();
                return PartialView("GetAll", DB.Employees.Include(emp => emp.Department).ToList());
            }
            ViewBag.departments = new SelectList(DB.Departments.ToList(), "DeptId", "DeptName", modifiedEmployee.DeptId);
            return PartialView(modifiedEmployee);
        }

        //Get: One Employee
        [HttpGet]
        public ActionResult Details(int id)
        {
            var employee = DB.Employees.Find(id);
            return PartialView(employee);
        }

        //check if email exists
        public JsonResult EmailExists(string Email)
        {
            return Json(!DB.Employees.Any(emp => emp.Email.ToLower() == Email.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}