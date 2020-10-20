using System;

namespace baby_tracker
{
    class dirtyDiaper
    {
        public int pooDiaper { get; set;}
        public int peeDiaper{ get; set;} 
        public int mixedDiaper {get; set;}

        public dirtyDiaper(int poo, int pee, int mix)
        {
            pooDiaper = poo;
            peeDiaper = pee;
            mixedDiaper = mix;

        }
    }
}