using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task01.Models;

namespace Task01.Controllers
{
    public class HomeController : Controller
    {
        CompanyContext db;
        public HomeController(CompanyContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            var emps = db.Employees.Include(ww => ww.Department).ToList();
            return View(emps);
        }
    }
}
