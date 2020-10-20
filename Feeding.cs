using System;

namespace baby_tracker
{
    class Feed
    {
        public int timeFed { get; set;}
        public int amountFed{ get; set;}         
        public Feed(int time, int amount)
        {
            timeFed = time;
            amountFed = amount;           
        }
    }
}