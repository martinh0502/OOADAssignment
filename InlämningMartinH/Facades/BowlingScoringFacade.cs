using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BowlingLaneService;
using PointsService;

namespace BengansBowling.Facades
{
    public interface IFacade
    {
        int PlayRound();
    }
    public class BowlingScoringFacade : IFacade
    {
       
        public int PlayRound()
        {
            LaneManager laneManager = new LaneManager();
            ScoringSystem scoringSystem = new ScoringSystem();

            bool[] firstRoll = new bool[10];
            bool[] secondRoll = new bool[10];

            firstRoll = laneManager.GetPinsHit(firstRoll);
            secondRoll = laneManager.GetPinsHit(firstRoll);

            return scoringSystem.GetPoints(firstRoll, secondRoll);
        }
    }
}
