using Microsoft.EntityFrameworkCore;
using System;

namespace HotelManag
{
    class Program
    {
        static void Main(string[] args)
        {
            using (LoginManager Context = new())
            {
                Context.Database.Migrate();
                Kitchen K01 = new Kitchen() { User_name = "kitchen", Pass_word = "kitchen" };
                Frontend U01 = new Frontend() { User_name = "admin", Pass_word = "admin" };
                Context.Add(K01);
                Context.Add(U01);
                Context.SaveChanges();
            }
        }
    }
}