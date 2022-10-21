using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMVVM.Model
{
    public class Ordinacija : Room
    {
        public Ordinacija( string name, string location, bool availability) : base(name, location, availability)
        {

        }
    }
}
