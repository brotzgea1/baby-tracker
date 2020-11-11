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
                Console.WriteLine("2) Profile Search");
                Console.WriteLine("3) Add new Measurements");
                Console.WriteLine("4) Calculate Age");
                Console.WriteLine("5) Exit");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                 {
                     case "1":
                        CreateProfile(bebe);
                        return true;
                     case "2":
                        SelectProfile(bebe);
                        return true;
                    case "3":
                        GrowthChart(bebe);
                        return true;
                    case "4":
                        HowOld(bebe);
                        return true;
                     case "5":
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
                Console.WriteLine("Write your baby's birth date? (yyyy/mm/dd)");
                DateTime dob = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine(result + " was " + reply + " pounds at birth and " + response + " inches long!");
                Baby baby1 = new Baby(result, reply1, response1, dob);
                bebe.Add(baby1);
                Console.WriteLine(baby1);
                return result + reply + response;         
            }

        public static string SelectProfile(List<Baby> bebe)
            {
                
                Console.WriteLine("Please enter the name of your baby. ");
                string result = Console.ReadLine();
                foreach(Baby ababy in bebe)
                {
                    if(result == ababy.Name)
                    {
                        var nifty = ababy;
                        Console.WriteLine(ababy);
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
                return result;
            } 

        public static string GrowthChart(List<Baby> bebe)
            {
                Console.WriteLine("Enter your baby's name. ");
                var result = Console.ReadLine();
                foreach(Baby ababy in bebe)
                {
                    if(result == ababy.Name)
                    {
                        Console.WriteLine("What is your baby's current weight? ");
                        string answer = Console.ReadLine();
                        int answer1 = int.Parse(answer);
                        ababy.CurWeight = answer1;
                        int newWeight = ababy.CurWeight - ababy.InitWeight;
                        Console.WriteLine("What is your baby's current height? ");
                        string reply = Console.ReadLine();
                        int reply1 = int.Parse(reply);
                        ababy.CurHeight = reply1;
                        int newHeight = ababy.CurHeight - ababy.InitHeight;
                        Console.WriteLine("Your baby has grown by: " + newWeight + " pounds and " + newHeight + " inches");
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
                return result;

            }

        public static string HowOld(List<Baby> bebe)
        {
            Console.WriteLine("Who's age do you want to get?");
            string reply = Console.ReadLine();
            foreach (Baby ababy in bebe)
            {
                if (ababy.Name == reply)
                {
                    int age = DateTime.Now.Year - ababy.Date.Year;
                    Console.WriteLine( ababy.Name + " is " + age + " years old.");
                }
            }
            return reply;
        }
        
        
    }
}
