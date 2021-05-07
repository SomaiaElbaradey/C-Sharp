using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Lab02._00.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab02._00
{
    [HubName("course")]
    public class CourseHub : Hub
    {
        ITIContext context = new ITIContext();
        public void addCourse(int Crs_Id,string Crs_Name,int Crs_Duration,int Top_Id)
        {
            Course course01 = new Course()
            {
                Top_Id = Top_Id,
                Crs_Duration = Crs_Duration,
                Crs_Id = Crs_Id,
                Crs_Name = Crs_Name
            };
            context.Courses.Add(course01);
            context.SaveChanges();

            Clients.All.newCourse(Top_Id, Crs_Name, Crs_Id, Crs_Duration);

        }
    }
}