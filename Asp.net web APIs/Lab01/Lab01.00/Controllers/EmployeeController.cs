using Lab01._00.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Lab01._00.Controllers
{
    public class EmployeeController : ApiController
    {
        private CompanyContext db = new CompanyContext();

        // GET: All
        public IHttpActionResult GetEmployees()
        {
            var allEmps = db.Employees.ToList();
            if (allEmps.Count > 0)
                return Ok(allEmps);
            else
                return NotFound();
        }

        // GET: One
        [ResponseType(typeof(Employee))]
        public IHttpActionResult GetEmployee(int id)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
                return NotFound();
            return Ok(employee);
        }

        // PUT: Employee
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEmployee(int id, Employee employee)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != employee.Id)
                return BadRequest();

            db.Entry(employee).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(id))
                    return NotFound();
                else
                    throw;
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: New Employee
        [ResponseType(typeof(Employee))]
        public IHttpActionResult PostEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            db.Employees.Add(employee);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = employee.Id }, employee);
        }

        // DELETE: Employee
        [ResponseType(typeof(Employee))]
        public IHttpActionResult DeleteEmployee(int id)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
                return NotFound(); 

            db.Employees.Remove(employee);
            db.SaveChanges();

            return Ok(employee);
        }

        private bool EmployeeExists(int id)
        {
            return db.Employees.Count(e => e.Id == id) > 0;
        }
    }
}