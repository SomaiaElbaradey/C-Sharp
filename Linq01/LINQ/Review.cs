﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    public class Review
    {
        public Book Book { get; set; }
        //public Guid User {get; set;}
        public User User { get; set; }
        public int Rating { get; set; }
        public String Comments { get; set; }
    }
}
