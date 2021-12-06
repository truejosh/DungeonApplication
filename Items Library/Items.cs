using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items_Library
{
    public class Items
    {



        public int Price { get; set; }
        public string Name { get; set; }

        public Items(int price, string name)
        {
            Price = price;
            Name = name;
        }

        public override string ToString()
        {
            return base.ToString(); 
        }












    }
}
