using APICoreIsmalia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICoreIsmalia.repository
{
   public interface IStudentRepository
    {
        List<Student> getall();
        Student getbyid(int id);
        //add,edit,delelet
    }
}
