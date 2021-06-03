using APICoreIsmalia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICoreIsmalia.repository
{
    public class studentlistrepository : IStudentRepository
    {
        public static List<Student> sts = new List<Student>()
        {
            new Student(){Id=1,Name="ali",Age=22 },
            new Student(){Id=1,Name="ali",Age=22 },
            new Student(){Id=1,Name="ali",Age=22 },
            new Student(){Id=1,Name="ali",Age=22 },
            new Student(){Id=1,Name="ali",Age=22 }
        };
        public List<Student> getall()
        {
            return sts;
        }

        public Student getbyid(int id)
        {
            return sts.Find(n=>n.Id==id);
        }
    }
}
