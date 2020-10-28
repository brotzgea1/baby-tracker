using System;


    class Sleep
    {
        public int timeSlept { get; set;}        

        public Sleep(int time)
        {
            timeSlept = time;
        }
        public override string ToString()
        {
            return "Your baby slept for " + timeSlept + " hours!";
        }
    }
