using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Authentication;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using RestSharp;
using web.Models;

namespace web.Controllers
{
    public class HomeController : Controller
    {
        public readonly RestClient client;

        public HomeController()
        {
            this.client = new RestClient("https://localhost:44363/api/database");
        }
        public IActionResult Index()
        {
            var request = new RestRequest("getItems", Method.GET);
            IRestResponse<List<Item>> response = client.Execute<List<Item>>(request);
            return View(response.Data ?? new List<Item>());
        }

        [HttpPost]
        public IActionResult AddNewItem(string name, string serial, double price)
        {
            var request = new RestRequest($"Create/{name}/{serial}/{price}", Method.GET);
            client.Execute(request);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult AddItem(string id)
        {
            var request = new RestRequest("AddItemToCart/" + id, Method.GET);
            client.Execute(request);
            return RedirectToAction(nameof(POS));
        }
        
        public IActionResult SubItem(string id)
        {
            var request = new RestRequest("SubItem/" + id, Method.GET);
            client.Execute(request);
            return RedirectToAction(nameof(POS));
        }

        public IActionResult RemoveItem(string id)
        {
            var request = new RestRequest("RemoveItemFromCart/" + id, Method.GET);
            client.Execute(request);
            return RedirectToAction(nameof(POS));
        }

        public IActionResult POS()
        {
            var request = new RestRequest("GetCartItems", Method.GET);
            IRestResponse<List<CartItem>> response = client.Execute<List<CartItem>>(request);
            var Model = new Cart
            {
                items = response.Data
            };
            Model.totalprice = Model.items.Sum(it => { return it.amount * it.price; });
            return View(Model);
        }
    }
}
