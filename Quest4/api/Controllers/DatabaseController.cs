using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api.Models;
using api.Dac;

namespace api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DatabaseController : ControllerBase
    {
        private readonly DatabaseDac DBDac;

        public DatabaseController() {
            this.DBDac = new DatabaseDac();
        }

        [HttpGet("{name}/{serial}/{price}")]
        public void Create(string name, string serial, double price)
        {
            var item = new Item
            {
                _id = Guid.NewGuid().ToString(),
                name = name,
                serial = serial,
                price = price
            };
            this.DBDac.CreateNewItem(item);
        }

        [HttpGet]
        public List<Item> GetItems()
        {
            return this.DBDac.ItemList(it => true);
        }

        [HttpGet()]
        public List<CartItem> GetCartItems()
        {
            return this.DBDac.CartItemList(it => true);
        }

        [HttpGet("{id}")]
        public void AddItemToCart(string id)
        {
            if (this.DBDac.CartItemList(it => true).FirstOrDefault(it => it._id == id) == null)
            {
                var item = GetItems().First(it => it._id == id);
                var cartitem = new CartItem
                {
                    _id = item._id,
                    name = item.name,
                    serial = item.serial,
                    price = item.price,
                    amount = 1
                };
                this.DBDac.Create(cartitem);
            }
            else
            {
                AddAmount(id);
            }
        }

        [HttpGet("{id}")]
        public void AddAmount(string id)
        {
            var cartitem = this.DBDac.CartItemList(it => true).FirstOrDefault(it => it._id == id);
            cartitem.amount++;
            this.DBDac.Update(cartitem);
        }

        [HttpGet("{id}")]
        public void SubItem(string id)
        {
            var cartitem = this.DBDac.CartItemList(it => true).FirstOrDefault(it => it._id == id);
            cartitem.amount--;
            if (cartitem.amount == 0)
                RemoveItemFromCart(id);
            else
                this.DBDac.Update(cartitem);
        }

        [HttpGet("{id}")]
        public void RemoveItemFromCart(string id)
        {
            var cartitem = this.DBDac.CartItemList(it => true).FirstOrDefault(it => it._id == id);
            this.DBDac.Remove(cartitem);
        }
    }
}
