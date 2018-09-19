using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        IEnumerable<PersonAndChoose> items;
        public HomeController()
        {
            items = new List<PersonAndChoose>
            {
               new PersonAndChoose
               {
                   Name = "Gen",
                   Num = 17
               },
               new PersonAndChoose
               {
                   Name = "P",
                   Num = 25
               },
               new PersonAndChoose
               {
                   Name = "Pao",
                   Num = 26
               },
               new PersonAndChoose
               {
                   Name = "To",
                   Num = 27
               },
                new PersonAndChoose
               {
                   Name = "To",
                   Num = 26
               },
                new PersonAndChoose
               {
                   Name = "Cap",
                   Num = 30
               },
            };
        }
        
        public IActionResult Index()
        {
            
            return View(items);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        
        public IActionResult ResultLotto()
        {
            var rng = new Random();
            int number = rng.Next(1, 100) ;
            ViewBag.number = number;
            var winner = items.Where(x => x.Num == number);
            return View(winner);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
    public class PersonAndChoose
    {
        public string Name {get;set;}
        public int Num {get;set;}
    }
}
