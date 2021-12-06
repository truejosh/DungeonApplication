using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boss_Library;
using Heros_Library;

namespace Boss_Library
{
    public class Combat
    {
        public static void DoAttack(Heros attacker, Boss defender)
        {
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            if (diceRoll <= 50)
            {
                defender.Health -= attacker.Damage;
                Console.WriteLine($"You hit {defender.Name} for {attacker.Damage} damage!\n {defender.Name} now has {defender.Health} health");
            }
            else
            {
                attacker.Health -= defender.Damage ;
                
                Console.WriteLine($"You missed!");
                Console.WriteLine($"{defender.Name} hit you for {defender.Damage}.\n Your Health is now {attacker.Health}/{attacker.MaxHealth}");
            }
        }
        public static void DoBattle(Heros hero, Boss boss)
        {
            DoAttack(hero, boss);
            if (boss.Health > 0)
            {
                hero.Health -= boss.Damage;
            }
        }
    }
}
