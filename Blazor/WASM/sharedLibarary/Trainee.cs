using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharedLibarary
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set;  }
        public int TrackId { get; set; }
        public virtual Track Track { get; set; }
        public bool IsGraduated { get; set; }
        public Gender Gender { get; set; }
    }
}
