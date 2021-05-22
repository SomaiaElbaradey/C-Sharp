using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharedLibarary
{
    public class ITIContext
    {
        public static List<Track> tracks = new List<Track>
            {
                new Track {Id= 1, Name = "SD", Description = "Software Development and BI Specialization"},
                new Track {Id= 2, Name = "UI", Description = "Specialized in UI and UX Development"},
                new Track {Id= 3, Name = "GD", Description = "Game Development"},
            };

        public static List<Trainee> trainees = new List<Trainee>()
        {
            new Trainee
            {
                Id = 1,
                Name = "Somaya",
                Email = "SomayaElbaradey@gmail.com",
                Gender = Gender.Female,
                PhoneNumber = "0119366585",
                IsGraduated = true,
                TrackId = 1,
                BirthDate = new DateTime(1997, 10, 1),
            },
            new Trainee
            {
                Id = 2,
                Name = "Anas",
                Email = "AnasMaher@gmail.com",
                Gender = Gender.Male,
                PhoneNumber = "0113697200",
                IsGraduated = true,
                TrackId = 3,
                BirthDate = new DateTime(1996, 3, 11),
            }
        };
    }
}