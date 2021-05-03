using System;
using System.Data.Entity;
using System.Linq;

namespace Lab01.Models
{
    public class ITI : DbContext
    {
        public ITI()
            : base("name=ITI")
        {
        }
        public virtual DbSet <Student> Students { get; set; }
    }
}