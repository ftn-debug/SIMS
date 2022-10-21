/***********************************************************************
 * Module:  Gost.cs
 * Author:  Lenovo
 * Purpose: Definition of the Class Model.Gost
 ***********************************************************************/

using System;

namespace ClassDiagram.Model
{
   public class Guest
   {
      private void Register()
      {
         throw new NotImplementedException();
      }
      
      public string name { get; set; }
      public string lastName { get; set; }
        public int id { get; set; }
        public String adress { get; set; }
        public int contact { get; set; }
        public Gender gender { get; set; }



    }
}