/***********************************************************************
 * Module:  RenovacijaProstorije.cs
 * Author:  majab
 * Purpose: Definition of the Class CRUDUpravnik.RenovacijaProstorije
 ***********************************************************************/

using System;

namespace ClassDiagram.Model
{
   public class RenovacijaProstorije
   {
      public Boolean StartRenovation(Room prostorija, DateTime startTime, DateTime endTime)
      {
         throw new NotImplementedException();
      }
      
      public DateTime startTime;
      public DateTime endTime;
      public Boolean isFinished;
      
      public Room room;
   
   }
}