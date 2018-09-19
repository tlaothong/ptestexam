using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace lotteryapi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LotteryController : ControllerBase
    {
        static List<Player> players = new List<Player>
            {
                new Player { Name = "John", LuckyNumber = 99 }
            };

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Player>> GetPlayer()
        {
            return players.ToList();
        }

        // GET api/values
        [HttpGet]
        public ActionResult<Winner> PickWinner()
        {
            //All player that has register should guessed number
            /*if (players.Any(x=>x.LuckyNumber == null))
            {
                throw new Exception("Some player not guess the number yet");
            }*/

            List<Player> winners = new List<Player>();
            Random rnd = new Random();
            int winnerNumber = -1;
            while (winners.Count == 0)
            {
                winnerNumber = rnd.Next(00, 100); 
                winners = players.Where(x=>x.LuckyNumber == winnerNumber).ToList();
            }  
            
            Winner w = new Winner{ WinnerNumber = winnerNumber, Players = winners };
            return w;
        }

        // POST api/values
        [HttpPost]
        public ActionResult<IEnumerable<Player>> Register([FromBody] Player pl)
        {
            if (players.Any(x=>x.Name == pl.Name))
            {
                throw new Exception("Duplicate name!");
            }
            players.Add(new Player { Name = pl.Name, LuckyNumber = null });
            return players.ToList();
        }

        // PUT api/values/5
        [HttpPost]
        public void GuessNumber([FromBody] Player pl)
        {
            var player = players.Where(x=>x.Name == pl.Name).FirstOrDefault();
            player.LuckyNumber = pl.LuckyNumber;
        }
    }

public  class Winner 
{
    public int WinnerNumber { get; set; } 
    public List<Player> Players { get; set; }
}
    public  class Player
    {
        public string Name { get; set; }
        public int ? LuckyNumber { get; set; }
    }
}
