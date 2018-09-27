using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ptestapi.Model;

namespace ptestapi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QuestionIIIController : ControllerBase
    {
        public static List<Player> players = new List<Player>();

        public QuestionIIIController()
        {
            
        }

        [HttpGet("")]
        public List<Player> GetPlayer()
        {
            if (players.Count() <1)
            {
                players.Add(new Player() { Name = "ake", Number = 99 });
            }
            return players;
        }

        [HttpGet("")]
        public List<Player> GetWinner()
        {
            //List<Player> plist = new List<Player>()
            //{
            //    new Player(){Name ="ake" , Number = 99 },
            //    new Player(){Name ="ae" , Number = 45 },
            //    new Player(){Name ="au" , Number = 67 },
            //    new Player(){Name ="to" , Number = 78 },
            //    new Player(){Name ="joker" , Number = 99 },
            //};
            // players = plist;

            if (players.Count < 1)
            {
                return new List<Player>();
            }

            var r = new Random();
            var randomnumber = r.Next(0, players.Count);

            var luckky = players[randomnumber];

            var winner = players.Where(x => x.Number == luckky.Number).ToList();

            return winner;
        }

        [HttpPost("")]
        public List<Player> AddPlayers([FromBody]Player newPlayer)
        {
            players.Add(newPlayer);

            return players;
        }
    }

    public class Player
    {
        public string Name { get; set; }
        public int Number { get; set; }
    }
}