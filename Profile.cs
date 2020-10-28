using System;
using System.Collections.Generic;


    public class Baby
    {
         private string name;
         private int weight;
         private int height;
         public Baby(string name, int weight, int height)
         {
             this.name = name;
             this.weight = weight;
             this.height = height;
         }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }


    public override string ToString()
    {
        return "Name: " + Name + " Weight: " + Weight + " Height: " + Height;
    } 
   
    }

    
