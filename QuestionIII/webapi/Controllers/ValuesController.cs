using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webapi.Models;

namespace webapi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpPost]
        public user[] GetAllUser([FromBody]user[] users)
        {
            var test = new Lottery();
            var _users = test.addArray(users);
            return _users;
        }

        // [HttpPost]
        // public void AddUser([FromBody]user users)
        // {
        //     var test = new Lottery();
        //     test.add(users);
        //     var users = GetUsersWinner();
        // }

        // [HttpGet]
        // public user[] GetUsersWinner()
        // {
        //     var test = new Lottery();
        //     var users = test.Winner();
        //     return users;
        // }

    }

    public class Lottery
    {
        public int randomNumber;

        public user[] addArray(user[] users)
        {
            var n = users.Length+1;
            var _users = users;
            users = new user[n];

            for (int i = 0; i < _users.Length; i++)
            {
                users[i] = _users[i];
            }

            return users;
        }

        public void Random()
        {
            Random number = new Random();
            randomNumber = number.Next(0, 99);
        }

        // public user[] Winner()
        // {
        //     var usersWinner = new user[0];
        //     while (usersWinner.Length == 0)
        //     {
        //         Random();
        //         usersWinner = users.Where(x => x.number == randomNumber).ToArray();
        //     }

        //     return usersWinner;
        // }


    }


}
