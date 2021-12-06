using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heros_Library
{
    public class Dwarf : Heros
    {

        public Dwarf() : base(15,"Dwarf",100,10,5,new Special("Double crit",2,10))
        {
          
        }
    }
}
