using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace baby_tracker
{
    class Program
    {  
        static void Main(string[] args)
        {  
            List<Baby> bebe = new List<Baby>();
            Console.Clear();
            bool showMenu = true;
            while(showMenu)
            {
                showMenu = DisplayMenu(bebe);
            }        
        }

        public static bool DisplayMenu(List<Baby> bebe)
            {
                
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Create new Profile");
                Console.WriteLine("2) Select Profile");
                Console.WriteLine("3) Exit");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                 {
                     case "1":
                        CreateProfile(bebe);
                        return true;
                     case "2":
                        SelectProfile();
                        return true;
                     case "3":
                        return false;
                     default:
                        return true;
                 }
            }
        public static string CreateProfile(List<Baby> bebe)
    {
        
        Console.WriteLine("What is your baby's name?");
        string result = Console.ReadLine();
        Console.WriteLine("How much did your baby weigh at birth in pounds?");
        string reply = Console.ReadLine();
        int reply1 = int.Parse(reply);
        Console.WriteLine("How tall was your baby at birth in inches?");
        string response = Console.ReadLine();
        int response1 = int.Parse(response);
        Console.WriteLine(result + " was " + reply + " pounds at birth and " + response + " inches long!");
        Baby baby1 = new Baby(result, reply1, response1);
        bebe.Add(baby1);
        Console.WriteLine(baby1);
        return result + reply + response;         
    }

    public static string SelectProfile()
    {
        Console.WriteLine("Please enter the name of your baby. ");
        string input = Console.ReadLine();
        return input;
    } 
        
        
    }
}
