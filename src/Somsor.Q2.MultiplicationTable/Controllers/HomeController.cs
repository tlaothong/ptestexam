using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Somsor.Q2.MultiplicationTable.Models;

namespace Somsor.Q2.MultiplicationTable.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int? n)
        {
            if(n.HasValue && n > 0)
            {
                var result = Enumerable.Range(1, n.Value).Select(x => Enumerable.Range(1, n.Value).Select(y => y * x));
                return View(result);
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
