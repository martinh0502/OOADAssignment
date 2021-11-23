using BengansBowling.Facades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BengansBowling.Models
{
    public class Match
    {
        public Match(Member player1, Member player2, Lane lane)
        {
            Player1 = player1;
            Player2 = player2;
            Lane = lane;
        }
        public Member Player1 { get; set; }
        public Member Player2 { get; set; }

        public Member Winner { get; set; }

        public int Player1Points { get; set; }
        public int Player2Points { get; set; }
        public Lane Lane { get; set; }

        public void PlayMatch()
        {
            for(int i = 0; i < 3; i++)
            {
                Serie serie = new Serie(new BowlingScoringFacade());

                serie.PlaySerie();

                Player1Points += serie.Player1Rounds.Sum();

                Player2Points += serie.Player2Rounds.Sum();
            }

            if(Player1Points > Player2Points)
            {
                Winner = Player1;
            }
            else
            {
                Winner = Player2;
            }

        }
    }
}
