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

            /* Santa is delivering presents to an infinite two-dimensional grid of houses.

             * He begins by delivering a present to the house at his starting location, and 
             * then an elf at the North Pole calls him via radio and tells him where to move next. 
             * Moves are always exactly one house to the north (^), south (v), east (>), or west (<). 
             * After each move, he delivers another present to the house at his new location.

             * However, the elf back at the north pole has had a little too much eggnog, and so his 
             * directions are a little off, and Santa ends up visiting some houses more than once. 
             * How many houses receive at least one present?

             * For example:

             * > delivers presents to 2 houses: one at the starting location, and one to the east.
             * ^>v< delivers presents to 4 houses in a square, including twice to the house at his 
             * starting/ending location.
             * ^v^v^v^v^v delivers a bunch of presents to some very lucky children at only 2 houses.
             */

            int x = 0;
            int y = 0;

            HashSet<string> houses = new HashSet<string>();

            houses.Add(x.ToString() + " " + y.ToString());

            string input = File.ReadAllText(@"C:\Users\Erin\Desktop\Git\AdventOfCode\Day3\Day3Input.txt");
            //string input = "^v^v^v^v^v";

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

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

            foreach (var item in houses)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(houses.Count);

            Console.ReadLine();
        }
    }
}
