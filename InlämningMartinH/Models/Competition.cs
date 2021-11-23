using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BengansBowling.Models
{
    public class Competition
    {
        public Competition(List<Member> members)
        {
            Date = DateTime.Now;
            Members = members;
            Matches = new List<Match>();
        }
        public DateTime Date { get; set; }
        public List<Member> Members { get; set; }

        public List<Match> Matches { get; set; }
        public Member Winner { get; set; }

        public void CalculateWinner()
        {
            int mostPoints = 0;

            foreach(Match match in Matches)
            {
                if(match.Player1Points > mostPoints || match.Player2Points > mostPoints)
                {
                    if (match.Player1Points > match.Player2Points)
                    {
                        mostPoints = match.Player1Points;
                        Winner = match.Player1;
                    }
                    else
                    {
                        mostPoints = match.Player2Points;
                        Winner = match.Player2;
                    }
                }
            }
        }
    }
}
