using System.Collections.Generic;

namespace quiz03.digithaiwebsite.Models
{
    public class CloseGuessVoteResult
    {
        public int WinnerNumber { get; set; }
        public IEnumerable<string> WinnerNames { get; set; }
        public string ErrorMessage { get; set; }
    }
}