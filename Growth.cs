using System;

namespace baby_tracker
{
    class Grow
    {
        public int Weight { get; set;}
        public int Height{ get; set;} 

        public Grow(int weight, int height)
        {
            Weight = weight;
            Height = height;
        }
    }
}