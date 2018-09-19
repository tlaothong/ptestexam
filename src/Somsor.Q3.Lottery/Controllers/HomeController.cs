using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Somsor.Q3.Lottery.Models;

namespace Somsor.Q3.Lottery.Controllers
{
    public class HomeController : Controller
    {
        public static List<Gambler> Gamblers = new List<Gambler>();

        public IActionResult Index()
        {
            return View(Gamblers);
        }

        public IActionResult Add(string name, int number)
        {
            if(number < 0 || number > 99)
            {
                TempData["ErrorMessage"] = "Number must in range 0-99.";
                return RedirectToAction(nameof(Index));
            }
            if(Gamblers.Any(x => x.Name == name.Trim()))
            {
                TempData["ErrorMessage"] = "Duplicate Gambler name.";
                return RedirectToAction(nameof(Index));
            }

            Gamblers.Add(new Gambler{
                Name = name,
                Number = number,
            });
            TempData["Message"] = "Gambler added.";

            return RedirectToAction(nameof(Index));
        }
        
        public IActionResult Result()
        {
            var ran = new Random();
            var ranNum = ran.Next(0, 100);
            ViewBag.ranNum = ranNum;
            var winGamblers = Gamblers.Where(x => x.Number == ranNum);
            return View(winGamblers);
        }
        
        public IActionResult Reset()
        {
            Gamblers = new List<Gambler>();
            return RedirectToAction(nameof(Index));
        }
        
        public IActionResult GenerateRandomGambler(int count)
        {
            var ran = new Random();
            Gamblers.AddRange(Enumerable.Range(1, count).Select(x=>new Gambler{
                Name = $"Gambler {x}",
                Number = ran.Next(0, 100),
            }).ToList());
            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
