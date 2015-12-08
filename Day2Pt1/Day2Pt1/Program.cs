using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Pt1
{
    class Program
    {
        static int smallest(int x, int y, int z)
        {
            int c = 0;

            while (x > 0 & y > 0 & z > 0)
            {
                x--; y--; z--; c++;
            }
            return c;
        }

        static void Main(string[] args)
        {


        /* The elves are running low on wrapping paper, and so they need to submit an order for more. 
         * They have a list of the dimensions (length l, width w, and height h) of each present, 
         * and only want to order exactly as much as they need.

         * Fortunately, every present is a box (a perfect right rectangular prism), which makes calculating 
         * the required wrapping paper for each gift a little easier: find the surface area of the box, 
         * which is 2*l*w + 2*w*h + 2*h*l. The elves also need a little extra paper for each present: 
         * the area of the smallest side.

         * For example:

         * A present with dimensions 2x3x4 requires 2*6 + 2*12 + 2*8 = 52 square feet of wrapping paper 
         * plus 6 square feet of slack, for a total of 58 square feet.
         * A present with dimensions 1x1x10 requires 2*1 + 2*10 + 2*10 = 42 square feet of wrapping paper 
         * plus 1 square foot of slack, for a total of 43 square feet.
         * All numbers in the elves' list are in feet. How many total square feet of wrapping paper should they order?

         */

            string text = System.IO.File.ReadAllText(@"C:\Users\Erin\Desktop\Git\AdventOfCode\Day2Pt1\Day2Input.txt");


            int counter = 0;
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Erin\Desktop\Git\AdventOfCode\Day2Pt1\Day2Input.txt");

            while ((line = file.ReadLine()) != null)
            {
                int w = line.IndexOf("x");
                int width = Convert.ToInt32(line.Substring(0, w));

                int h = line.IndexOf("x", w + 2);

                //Need to work on my indexes
                //int height = Convert.ToInt32(line.Substring((w-2), (h-w-1)));
                int height = 0;

                Console.WriteLine(line + "-" + width + "-" + height);
                counter++;
            }


            //int x = 7;
            //int y = 30;
            //int z = 12;

            //Console.WriteLine(smallest(x, y, z));


            Console.ReadLine();
        }
    }
}
