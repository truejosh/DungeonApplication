using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss_Library
{
    public class Boss
    {
        //feilds
      

        //property
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }

       //ctor

        public Boss()
        {
            //default
        }

        public Boss(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }
        //method


        public override string ToString()
        { 
            return string.Format($"------{Name}-----\n " +
                $"Health: {Health}\n" +
                $"Damage: {Damage}");
        }


    }
}
