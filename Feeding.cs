using System;
using System.Collections.Generic;
    class Feed
    {
        private int timeFed;
        private int amountFed;
               
        public Feed(int time, int amount)
        {
            this.timeFed = time;
            this.amountFed = amount;           
        }

        public int TimeFed
        {
            get{ return timeFed; }
            set { timeFed = value; }
        }
        public int AmountFed
        {
            get{ return amountFed; }
            set { amountFed = value; }
        }

        public override string ToString()
    {
        return "Your baby ate: " + amountFed + " ounces over " + timeFed + " minutes!";
    }
    }
