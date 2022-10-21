using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMVVM.Model
{
    public class RoomService
    {
        private static ObservableCollection<Room> allRooms;

        public RoomService()
        {
            allRooms = new ObservableCollection<Room>();
            allRooms.Add(new Sala("S1", "Tu i tamo", true));
            allRooms.Add(new Sala("S12", "Tu i tamo", true));
            allRooms.Add(new Sala("S2", "Tu i tamo", true));
            allRooms.Add(new Sala("S3", "Tu i tamo", true));
        }
        public ObservableCollection<Room> getAllRooms(){
            return allRooms;
        
        }

        public bool AddRoom(Room newRoom)
        {
            if (newRoom == null)
            {
                return false;
            }
            if (allRooms == null)
            {
                allRooms = new ObservableCollection<Room>();
            }
            if (!allRooms.Contains(newRoom) && isUniqueName(newRoom.Name))
            {
                allRooms.Add(newRoom);
                return true;
            }
            return false;
        }

        public bool isUniqueID(String id)
        {
            foreach (var s in allRooms)
            {

                if (s.ID == id)
                {
                    return false;
                }

            }
            return true;
        }
        public bool isUniqueName(String name)
        {
            foreach (var s in allRooms)
            {
                if (s.Name == name)
                {
                    return false;
                }

            }
            return true;
        }

        public Boolean RemoveRoom(Room oldRoom)
        {
            if (oldRoom == null)
            {
                return false;
            }
            if (allRooms != null)
            {
                if (allRooms.Contains(oldRoom))
                {

                    allRooms.Remove(oldRoom);
                    return true;
                }
            }
            return false;
        }

        public void RemoveAllRoom()
        {
            if (allRooms != null)
                allRooms.Clear();
        }

        internal Boolean UpdateRoom(Room selected, string newName, string newLocation)
        {

            foreach (var r in allRooms)
            {
                if (r.ID == selected.ID)
                {
                    if (newName == selected.Name)
                    {
                        // r.name = newName;
                       
                        r.location = newLocation;

                        return true;

                    }
                    else if (newName != selected.Name && isUniqueName(newName))
                    {
                        r.Name = newName;
             
                        r.location = newLocation;

                        return true;
                    }

                }

            }
            return false;

        }

        internal Room getRoom(Room selected)
        {

            foreach (var s in allRooms)
            {
                if (s.ID == selected.ID)
                {
                    return s;
                }

            }
            return null;

        }

    }
}
