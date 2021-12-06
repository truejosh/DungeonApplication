using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heros_Library
{
    public class Wizard : Heros
    {


        public Wizard() : base(10, "Wizard", 100, 10, 20, new Special("Fire ball", 4, 20))
        {

        }
    }
}
