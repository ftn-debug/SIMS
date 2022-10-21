using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMVVM.Model
{
    public abstract class Room : INotifyPropertyChanged
    {

        private String id { get; set; }
        private String name { get; set; }
        public String location { get; set; }
        public Boolean availability { get; set; }

        protected Room( string name, string location, bool availability)
        {
            this.id = generateID() ;
            this.name = name;
            this.location = location;
            this.availability = availability;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged(string properyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(properyName));
            }
        }

        public String ID
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("ID");
            }
        }
        public String Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public String Location
        {
            get { return location; }
            set
            {
                location = value;
                OnPropertyChanged("Location");
            }
        }
        public Boolean Availability
        {
            get { return availability; }
            set
            {
                availability = value;
                OnPropertyChanged("Availability");
            }
        }

      

        public string generateID()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }

    }
}
