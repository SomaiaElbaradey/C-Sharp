using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APICoreIsmalia.Models;

namespace APICoreIsmalia.repository
{
    public class studentRepository:IStudentRepository
    {
        testapiContext db;
        public studentRepository(testapiContext db)
        {
            this.db = db;
        }
        //getall

        public List<Student> getall()
        {
            return db.Students.ToList();
        }


        //getbyid
         public Student getbyid(int id)
        {
            return db.Students.Where(n => n.Id == id).FirstOrDefault();
        }

        //add

        //edit

        //delete
    }
}
