/***********************************************************************
 * Module:  Room.cs
 * Author:  majab
 * Purpose: Definition of the Class CRUDUpravnik.Room
 ***********************************************************************/

using System;
using System.Collections.Generic;

namespace ClassDiagram.Model
{
    [Serializable]

    public abstract class Room
   {
      public Boolean Edit()
      {
         throw new NotImplementedException();
      }
      
      public Boolean Update()
      {
         throw new NotImplementedException();
      }
      
      public Boolean Delete()
      {
         throw new NotImplementedException();
      }
      
      public Boolean SetAvailability()
      {
         throw new NotImplementedException();
      }
      
      /// //Room name
      public int name { get; set; }
      public TipProstorija roomType;
      public String location;
      public Boolean availability = true;
      public List<Inventory> inventoryList = null;
      
      public RenovacijaProstorije renovation;

       
    }
}