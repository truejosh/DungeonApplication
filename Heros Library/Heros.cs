using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heros_Library
{
    public class Heros
    {

        //feilds
        private int _health;
        private Dictionary<int, string> specialTypes = new Dictionary<int, string>() {
            {1,"Maxhealth"}, {2,"CritChance"}, {3,"Health"}, {4,"Damage"}
        };



        //property
        public string Name { get; set; }
        public int MaxHealth { get; set; }
        public int CritChance { get; set; }
        public int Damage { get; set; }
        public Special CharSpecial { get; set; }

        public int Health
        {
            get { return _health; }
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


        //ctor

        public Heros(int health, string name, int maxHealth, int critChance, int damage, Special charspecial)
        {
            MaxHealth = maxHealth;
            Health = health;
            Name = name;
            CritChance = critChance;
            Damage = damage;
            CharSpecial = charspecial;
            switch (CharSpecial.SpecialType)
            {
                case 1:
                    MaxHealth = MaxHealth + charspecial.SpecialValue;
                    break;
                case 2:
                    CritChance = CritChance + charspecial.SpecialValue;
                    break;
                case 3:
                    Health = Health + charspecial.SpecialValue;
                    break;
                case 4:
                    Damage = Damage + charspecial.SpecialValue;
                    break;
                default:
                    break;
            }
        }



        //method


        public override string ToString()
        {
            return string.Format($"------{Name}-----\n Health: {Health} of {MaxHealth} max health\n Damage:{Damage} ");
        }








    }//end public
}//end namespace
