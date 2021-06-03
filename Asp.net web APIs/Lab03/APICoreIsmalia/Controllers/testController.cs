using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APICoreIsmalia.Models;
using APICoreIsmalia.repository;


namespace APICoreIsmalia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class testController : ControllerBase
    {


        IStudentRepository st;
        public testController(IStudentRepository st)
        {
            this.st = st;
        }
        [HttpGet]
        public ActionResult displayall()
        {
            return Ok(st.getall());
        }
        [HttpGet("{id}")]
        public ActionResult<Student> getbyid(int id)
        {
            Student s = st.getbyid(id);

            if (s == null)
                return NotFound();
            else
                return s;

        }
    }

}
