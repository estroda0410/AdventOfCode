using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Pt1
{
    class Program
    {
        static void Main(string[] args)
        {

            /* The next year, to speed up the process, Santa creates a robot version of himself, 
             * Robo-Santa, to deliver presents with him.

             * Santa and Robo-Santa start at the same location (delivering two presents to the same starting house), 
             * then take turns moving based on instructions from the elf, who is eggnoggedly reading from the 
             * same script as the previous year.

             * This year, how many houses receive at least one present?

             * For example:

             * ^v delivers presents to 3 houses, because Santa goes north, and then Robo-Santa goes south.
             * ^>v< now delivers presents to 3 houses, and Santa and Robo-Santa end up back where they started.
             * ^v^v^v^v^v now delivers presents to 11 houses, with Santa going one direction and Robo-Santa going the other.
             */


            int x = 0;
            int y = 0;
            int robox = 0;
            int roboy = 0;

            HashSet<string> houses = new HashSet<string>();

            houses.Add(x.ToString() + " " + y.ToString());

            string input = File.ReadAllText(@"C:\Users\Erin\Desktop\Git\AdventOfCode\Day3\Day3Input.txt");

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (i % 2 == 0)
                {
                    switch (c)
                    {
                        case '^':
                            y++;
                            break;
                        case 'v':
                            y--;
                            break;
                        case '>':
                            x++;
                            break;
                        case '<':
                            x--;
                            break;
                        default:
                            continue;
                    }
                    houses.Add(x.ToString() + " " + y.ToString());
                }
                else
                {
                    switch (c)
                    {
                        case '^':
                            roboy++;
                            break;
                        case 'v':
                            roboy--;
                            break;
                        case '>':
                            robox++;
                            break;
                        case '<':
                            robox--;
                            break;
                        default:
                            continue;
                    }
                    houses.Add(robox.ToString() + " " + roboy.ToString());
                }

            }

            Console.WriteLine(houses.Count);

            Console.ReadLine();
        }
    }
}
