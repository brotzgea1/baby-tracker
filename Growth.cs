using System;


    class Grow
    {
        public int Weight { get; set;}
        public int Height{ get; set;} 

        public Grow(int weight, int height)
        {
            Weight = weight;
            Height = height;
        }

        public override string ToString()
    {
        return "Your baby is " + Weight + " pounds and is " + Height + " inches long!";
    }
    }
