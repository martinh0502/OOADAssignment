using System;

namespace PointsService
{
    public class ScoringSystem
    {
        public int GetPoints(bool[] pins1, bool[] pins2)
        {
            int points = 0;

            bool strike = true;

            foreach(bool pin in pins1)
            {
                if (pin == false)
                {
                    strike = false;
                }
                
            }
            foreach(bool pin in pins2)
            {
                if(pin == true)
                {
                    points++;
                }
            }

            if (strike == true)
            {
                return 30;
            }
            else if(points == 10)
            {
                return 20;
            }
            else
            {
                return points;
            }
        }
    }
}
