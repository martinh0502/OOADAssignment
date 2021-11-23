using BengansBowling.Facades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BengansBowling.Models
{
    public class Serie
    {
        private IFacade _facade;
        public Serie(IFacade facade)
        {
            _facade = facade;

            Player1Rounds = new int[10];
            Player2Rounds = new int[10];
        }
        public int[] Player1Rounds { get; set; }
        public int[] Player2Rounds { get; set; }

        public void PlaySerie()
        {
            int[] totalPoints = new int[2];

            for(int i = 0; i < 10; i++)
            {
                Player1Rounds[i] = _facade.PlayRound();
                Player2Rounds[i] = _facade.PlayRound();
            }

            
        }


    }

}
