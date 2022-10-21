/***********************************************************************
 * Module:  RoomIventory.cs
 * Author:  majab
 * Purpose: Definition of the Class CRUDUpravnik.RoomIventory
 ***********************************************************************/

using System;
using System.Collections.Generic;

namespace ClassDiagram.Model
{
   public class RoomIventory
   {
      public List<Room> GetAll()
      {
         throw new NotImplementedException();
      }
      
      public List<Room> GetByType()
      {
         throw new NotImplementedException();
      }
      
      public List<Room> GetByAvailability()
      {
         throw new NotImplementedException();
      }
      
      public List<Room> GetRenovating()
      {
         throw new NotImplementedException();
      }
      
      public int AddRoom()
      {
         throw new NotImplementedException();
      }
      
      public int Delete()
      {
         throw new NotImplementedException();
      }
      
      public int totalNumber;
      
      public System.Collections.Generic.List<Room> room;
      
      public System.Collections.Generic.List<Room> Room
      {
         get
         {
            if (room == null)
               room = new System.Collections.Generic.List<Room>();
            return room;
         }
         set
         {
            RemoveAllRoom();
            if (value != null)
            {
               foreach (Room oRoom in value)
                  AddRoom(oRoom);
            }
         }
      }
      
      
      public void AddRoom(Room newRoom)
      {
         if (newRoom == null)
            return;
         if (this.room == null)
            this.room = new System.Collections.Generic.List<Room>();
         if (!this.room.Contains(newRoom))
            this.room.Add(newRoom);
      }
      
      public void RemoveRoom(Room oldRoom)
      {
         if (oldRoom == null)
            return;
         if (this.room != null)
            if (this.room.Contains(oldRoom))
               this.room.Remove(oldRoom);
      }
      
      public void RemoveAllRoom()
      {
         if (room != null)
            room.Clear();
      }
   
   }
}