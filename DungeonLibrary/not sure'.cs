using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    class Bosses
    {

        //feilds
        private int _health;
        private int _block;
        //property
        public string Name { get; set; }
        public int MaxHealth { get; set; }
        public int Gold { get; set; }

        public int Health
        {
            get { return Health; }
            set
            {
                if (value <= MaxHealth)
                {
                    _health = value;
                }
                else
                {
                    _health = MaxHealth;
                }
            }
        }//end prop health

        public int Block
        {
            get { return _block; }
            set
            {
                if (Block < 0)
                {
                    Block = 0;
                }

                else
                {
                    Block = value;
                }
            }
        }//end prop block

        //ctor

        public Bosses(int health, string name, int maxHealth, int gold)
        {
            Health = health;
            Name = name;
            MaxHealth = maxHealth;
            Gold = gold;
        }

        //method

        public override string ToString()
        {
            return base.ToString();
        }

    }//class
}//namesapce
