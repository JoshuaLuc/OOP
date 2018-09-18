using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    class Program
    {
        static void Main(string[] args)
        {
            float player_health = 100;
            bool both_players_alive = true;

            while (both_players_alive == true)
            {





                bool keepLooping = true;

                while (keepLooping == true)
                {
                    Console.WriteLine("Choose a Attack Type");
                    Console.WriteLine("1: Range Attack");
                    Console.WriteLine("2: Melee Attack");
                    int Yeet = int.Parse(Console.ReadLine());

                    switch (Yeet)
                    {
                        case 1:
                            Console.WriteLine("Range Weapons");
                            Console.WriteLine("1: Sling Shot");
                            Console.WriteLine("2: Bow & Arrow");

                            int Range = int.Parse(Console.ReadLine());
                            switch (Range)
                            {
                                case 1:
                                    Console.WriteLine("Bow & Arrow");
                                    break;
                                case 2:
                                    Console.WriteLine("Sling Shot");
                                    break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Melee Weapons");
                            break;
                        default:
                            Console.WriteLine("Default case");
                            break;
                    }


                }
                if (player_health <= 0)
                {
                
                Console.WriteLine("You Have Died");
                }
                else
                {
                    Console.WriteLine("You Win!");
                }

            }
        }
    }
}
