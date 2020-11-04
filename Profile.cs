using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


    public class Baby
    {
        public string Name { get; set; }
        public int InitWeight { get; set; }
        public int InitHeight { get; set; }
        public int CurWeight { get; set; }
        public int CurHeight { get; set; }
         public Baby(string name, int weight, int height)
         {
             Name = name;
             InitWeight = weight;
             InitHeight = height;
         }

    public override string ToString()
    {
        return "Name: " + Name + " Weight: " + InitWeight + " Height: " + InitHeight;
    } 
   
    }

    
