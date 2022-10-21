using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMVVM.Model
{
    public class Sala : Room
    {
        public Sala( string name, string location, bool availability) : base( name, location, availability)
        {
        }
    }
}
