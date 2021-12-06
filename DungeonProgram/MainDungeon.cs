using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heros_Library;
using Boss_Library;
using Items_Library;


namespace DungeonProgram
{
    class MainDungeon
    {
        static void Main(string[] args)
        {

            bool userRepeat = true;
            int bossesKilled = 0;
            bool exit = false;

            do
            {
                Boss b1 = new Gragas();
                Boss b2 = new Trundle();
                Boss b3 = new Mundo();
                Boss b4 = new Ramus();
                Boss b5 = new Zac();

                Boss[] bosses = { b1, b2, b3, b4, b5 };

                Random rand = new Random();
                int randomNbr = rand.Next(bosses.Length);
                Boss boss = bosses[randomNbr];

                Console.WriteLine("Welcome to the Dungeon GAME!");
                Heros userChar = CharacterSelection(ref userRepeat);//selecting character method
                Console.WriteLine($"{boss.Name}\nIs Ready To Fight!");

                while (userRepeat)
                {
                    /*Maybe could add items to buy */
                    Console.WriteLine("\nPlease choose an action\nH) Hit\nM) Monster Information\nP) Players stats \nS) Check your score\nC) Change character\nX) Exit Game\n");
                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    switch (userChoice)
                    {
                        case ConsoleKey.H:
                            Console.Clear();
                            Combat.DoBattle(userChar, boss);
                            if (userChar.Health <= 0)
                            {
                                Console.WriteLine($"You have been killed by {boss.Name}\n Game over!");
                                userRepeat = false;
                                Console.WriteLine("Would you like to play again Y/N");
                                ConsoleKey death = Console.ReadKey(true).Key;
                                switch (death)
                                {
                                    case ConsoleKey.Y:

                                        break;
                                    case ConsoleKey.N:
                                        exit = true;
                                        break;
                                    default:
                                        Console.WriteLine("Please select Y or N");
                                        break;
                                }
                                Console.Clear();
                                break;
                            }
                            if (boss.Health <= 0)
                            {
                                Console.WriteLine($"\nYou killed {boss.Name}!\n");
                                bossesKilled++;

                                userRepeat = false;
                            }


                            break;

                        case ConsoleKey.P:
                            Console.Clear();
                            Console.WriteLine($"The {userChar.Name}'s stats are curently \nHealth:{userChar.Health}/{userChar.MaxHealth}\nDamage:{userChar.Damage}");
                            break;


                        case ConsoleKey.M:
                            Console.Clear();
                            Console.WriteLine("Monster Information");
                            Console.WriteLine(boss);
                            break;


                        case ConsoleKey.S:
                            Console.Clear();
                            Console.WriteLine($"You have killed {bossesKilled} bosses");
                            break;


                        case ConsoleKey.C:
                            Console.Clear();
                            userChar = CharacterSelection(ref userRepeat);
                            break;

                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            Console.Clear();
                            Console.WriteLine("Are you sure you would like to quit the game? Y/N");
                            ConsoleKey pick5 = Console.ReadKey(true).Key;
                            switch (pick5)
                            {
                                case ConsoleKey.Y:
                                    exit = true;
                                    userRepeat = false;
                                    break;
                                case ConsoleKey.N:
                                    break;
                                default:
                                    Console.WriteLine("Please try again. Your selection was not reconized");
                                    Console.Clear();
                                    break;
                            }
                            Console.Clear();
                            break;


                    }//switch
                }//while

            } while (!exit);
        }

        private static void Menu(ref bool userRepeat, ref Heros userChar, ref Boss bosses)
        {

        }//end while loop for character selection


        static Heros CharacterSelection(ref bool userRepeat)
        {
            Heros userChar = new Knight();
            bool charactersLoop = true;
            while (charactersLoop)
            {

                Console.WriteLine("Please select a character to see their information\n K) Knight\n W) Wizard\n V) Vampire\n D) Dwarf\n C) Clown");
                ConsoleKey character = Console.ReadKey(true).Key;
                switch (character)
                {
                    case ConsoleKey.K:
                        userChar = new Knight();
                        break;

                    case ConsoleKey.W:
                        userChar = new Wizard();
                        break;

                    case ConsoleKey.V:
                        userChar = new Vampire();
                        break;

                    case ConsoleKey.D:
                        userChar = new Dwarf();
                        break;

                    case ConsoleKey.C:
                        userChar = new Clown();
                        break;

                    default:
                        Console.WriteLine("Please try again...");
                        break;
                }//switch character
                Console.Clear();
                Console.WriteLine($"{userChar}\nWhould you like to select this Hero? Y/N");//display hero info and asking to confirm
                ConsoleKey characterRepeat = Console.ReadKey(true).Key;
                switch (characterRepeat)
                {
                    case ConsoleKey.Y:
                        userRepeat = true;
                        charactersLoop = false;
                        Console.Clear();
                        break;
                    case ConsoleKey.N:
                        Console.Clear();
                        break;
                }//end switch

            }
            return userChar;
        }//end method

        private static void GetBoss(ref int randomBoss)
        {
        }//end get boss method
    }//class
}//namespace
