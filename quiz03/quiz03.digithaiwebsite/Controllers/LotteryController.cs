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
        private static string AdminUsername = "admin";
        private static bool IsClosed;

        [HttpPost]
        public CreateNewGuessResult Post([FromBody] GuessInfo value)
        {
            if (IsClosed) return new CreateNewGuessResult { ErrorMessage = "This game is already closed." };

            var isDataCorrect = value != null && !string.IsNullOrEmpty(value.Name);
            if (!isDataCorrect)
                return new CreateNewGuessResult { ErrorMessage = $"Some input data is not valid." };

            var isGuessInAvailableRange = value.GuessNo >= 0 && value.GuessNo <= 99;
            if (!isGuessInAvailableRange)
                return new CreateNewGuessResult { ErrorMessage = $"Please guess a number between 0~99." };

            if (AllGuessesData.ContainsKey(value.Name))
                return new CreateNewGuessResult { ErrorMessage = $"You can't use name '{value.Name}'." };

            AllGuessesData.Add(value.Name, value);
            return new CreateNewGuessResult();
        }

        [HttpPost("close")]
        public CloseGuessVoteResult CloseGuessVote(CloseGuessVoteRequest req)
        {
            var isRequestValid = req != null && !string.IsNullOrEmpty(req.Username);
            if (!isRequestValid) return new CloseGuessVoteResult { ErrorMessage = "Some data are invalid." };

            var isRequestAllow = req.Username == AdminUsername;
            if (!isRequestAllow) return new CloseGuessVoteResult { ErrorMessage = "This user have not allow to do this command." };

            if (IsClosed) return new CloseGuessVoteResult { ErrorMessage = "This game is already closed." };

            IsClosed = true;

            var random = new Random();
            var winnerNo = random.Next(0, 100);
            var winnerQry = AllGuessesData.Where(it => it.Value.GuessNo == winnerNo);

            var result = new CloseGuessVoteResult
            {
                WinnerNumber = winnerNo,
                WinnerNames = winnerQry.Select(it => it.Key)
            };
            return result;
        }
    }
}
