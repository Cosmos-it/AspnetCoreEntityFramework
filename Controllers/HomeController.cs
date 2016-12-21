using System.Collections.Generic;
using System.Linq;
using ConferenceBarrel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace ConferenceBarrel.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult CreateConference()
        {
            var conference = new Conference{
                Name = "First Conference",
                TicketeVlaue = 249.00m
            };
            
            context.Conferences.Add(conference);
            context.SaveChanges();

            var sessionTitleList = new List<string> {
                ".NET Core", "AspNetCore", "Entity Framework"
            };

            foreach (var title in sessionTitleList)
            {
                var session = new Session{
                    Title = title,
                    Conference = conference
                };
                context.Sessions.Add(session);
                context.SaveChanges();
            }
            return RedirectToAction("ViewConference");
        }

       public IActionResult ViewConference()
        {   
            var conference = context.Conferences.Include(s => s.Sessions).First();
            return View(conference);

         }
    }
}
