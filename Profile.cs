using System;
using System.Collections.Generic;
// using Newtonsoft.Json;

namespace baby_tracker
{
    public class Baby
    {
         public string firstName{ get; set;}
         public string lastName{ get; set;}

         public Baby()
         {}

         public Baby(string firstname, string lastname)
         {
             firstName = firstname;
             lastName = lastname;
         }
    }


}