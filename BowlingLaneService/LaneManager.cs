using System;

namespace BowlingLaneService
{
    public class LaneManager
    {
        public bool[] GetPinsHit(bool[] pins)
        {
            Random random = new Random();

            for(int i = 0; i < 10; i++)
            {
                if(random.Next(15)>5 && pins[i] != true)
                {
                    pins[i] = true;
                }
            }
            return pins;
        }
    }
}
