using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task01.Models;

namespace Task01.Controllers
{
    public class EmployeeController : Controller
    {
        CompanyContext db;
        public EmployeeController(CompanyContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            var emps = db.Employees.Include(ww => ww.Department).ToList();
            return View(emps);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["depts"] = new SelectList(db.Departments.ToList(), "DeptId", "DeptName", 1);
            return View();       
        }

        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            db.Add(emp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var emp = db.Employees.Include(ww => ww.Department).FirstOrDefault(ww => ww.Id == id);
            ViewData["depts"] = new SelectList(db.Departments.ToList(), "DeptId", "DeptName", emp.DeptId);
            return View(emp);
        }

        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
            db.Update(emp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var emp = db.Employees.Include(ww => ww.Department).FirstOrDefault(ww => ww.Id == id);
            ViewData["depts"] = new SelectList(db.Departments.ToList(), "DeptId", "DeptName", emp.DeptId);
            return View(emp);
        }

        [HttpPost]
        public IActionResult Delete(Employee emp)
        {
            db.Remove(emp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
