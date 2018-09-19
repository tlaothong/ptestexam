using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using quiz03.digithaiwebsite.Models;

namespace quiz03.digithaiwebsite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LotteryController : ControllerBase
    {
        private static Dictionary<string, GuessInfo> AllGuessesData = new Dictionary<string, GuessInfo>();

        [HttpPost]
        public CreateNewGuessResult Post([FromBody] GuessInfo value)
        {
            var isDataCorrect = value!=null && !string.IsNullOrEmpty(value.Name);
            if(!isDataCorrect)
                return new CreateNewGuessResult { ErrorMessage = $"Some input data is not valid." };

            var isGuessInAvailableRange = value.GuessNo >= 0 && value.GuessNo <= 99;
            if(!isGuessInAvailableRange) 
                return new CreateNewGuessResult { ErrorMessage = $"Please guess a number between 0~99." };

            if (AllGuessesData.ContainsKey(value.Name))
                return new CreateNewGuessResult { ErrorMessage = $"You can't use name '{value.Name}'." };

            AllGuessesData.Add(value.Name, value);
            return new CreateNewGuessResult();
        }
    }
}
