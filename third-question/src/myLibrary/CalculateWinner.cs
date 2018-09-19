using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace myLibrary
{
    public class CalculateWinner
    {
        public List<Player> RandomWinner(List<Player> player)
        {
            var random = new Random();
            var randomWinnerPlayerIndex = random.Next(0, player.Count);
            return player.Where(it => it.VoteNumber == player[randomWinnerPlayerIndex].VoteNumber).ToList();
        }
    }
}
