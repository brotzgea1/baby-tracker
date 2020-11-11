using System;
    public class Baby
    {
        public string Name { get; set; }
        public int InitWeight { get; set; }
        public int InitHeight { get; set; }
        public int CurWeight { get; set; }
        public int CurHeight { get; set; }
        public DateTime Date { get; set; }
         public Baby(string name, int weight, int height, DateTime date)
         {
             Name = name;
             InitWeight = weight;
             InitHeight = height;
             Date = date;
         }

    public override string ToString()
    {
        return "Name: " + Name + " Weight: " + InitWeight + " Height: " + InitHeight;
    } 
   
    }

    
