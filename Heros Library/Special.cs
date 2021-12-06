using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heros_Library
{
    public class Special
    {
        public string Name { get; set; }
       public int SpecialType { get; set; }
        public int SpecialValue { get; set; }

        public Special(string name, int specialType, int specialValue)
        {
            Name = name;
            SpecialType = specialType;
            SpecialValue = specialValue;
        }


      

    }
}
