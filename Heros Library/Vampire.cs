using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heros_Library
{
    public class Vampire : Heros
    {


        public Vampire() : base(10,"Vampire",100,10,10,new Special("bool'd steal helth from the enemy",3,10))
        {
           
        }
    }
}
