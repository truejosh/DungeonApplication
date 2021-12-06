using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heros_Library
{
    public class Knight : Heros
    {


        public Knight() : base(20, "Knight", 100, 10, 10, new Special("Block",3,25))
        {
            
            
        }

        
    }
}
