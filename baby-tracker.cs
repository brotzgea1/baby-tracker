using System;
using System.Collections.Generic;

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
            List<Baby> listBaby = new List<Baby>();            
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = First();
            }
            
        }
        public static bool First()
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Create new Profile");
                Console.WriteLine("2) Select Profile");
                Console.WriteLine("3) Exit");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        CreateProfile();
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
            public static string CreateProfile()
        {
            Baby baby = new Baby();
            Console.WriteLine("What is your baby's first name?");
            string name = Console.ReadLine();
            baby.firstName = name;
            Console.WriteLine("What is your baby's last name?");
            string surname = Console.ReadLine();
            baby.lastName = surname;
           return baby.firstName + baby.lastName;
        }
            

        public static string SelectProfile()
        {
            Console.WriteLine("Enter your baby's name");
            return Console.ReadLine();
        }

    }
}
