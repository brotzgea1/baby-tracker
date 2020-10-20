using System;

namespace baby_tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("\nWhat is your baby's name?");
            // var name = Console.ReadLine();
            
            // Console.WriteLine("\nWhat do you want to track?");
            // Console.ReadLine();
            dirtyDiaper dirty = new dirtyDiaper(1, 2, 0);
            
            Console.WriteLine(dirty.pooDiaper);
        }
    }
}
