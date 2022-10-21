using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMVVM.Model
{
    public class Soba : Room
    {
        public Soba( string name, string location, bool availability) : base( name, location, availability)
        {
        }
    }
}
