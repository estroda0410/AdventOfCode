using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Pt1
{
    class Program
    {
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

            int counter = 0;
            int total = 0;
            string line;

            StreamReader file = new StreamReader(@"C:\Users\Erin\Desktop\Git\AdventOfCode\Day2Pt1\Day2Input.txt");
            //StreamReader file = new StreamReader(@"C:\Users\Erin\Desktop\Git\AdventOfCode\Day2Pt1\TestInput.txt");

            while ((line = file.ReadLine()) != null)
            {
                int area = 0;

                int endW = line.IndexOf("x");
                int w = Convert.ToInt16(line.Substring(0, endW));

                int beginH = endW + 1;
                int endH = line.LastIndexOf("x");
                int beginL = endH + 1;
                int h = Convert.ToInt16(line.Substring(beginH, (endH - beginH)));
                int l = Convert.ToInt16(line.Substring(beginL, (line.Length - beginL)));

                int a1 = w * h;
                int a2 = h * l;
                int a3 = l * w;

                int s = smallest(a1, a2, a3);

                area = (2 * a1) + (2 * a2) + (2 * a3) + s;
                total = total + area;

                //Console.WriteLine(w + "-" + h + "-" + l + "-" + s + "-" + area + "-" + total);
                counter++;
            }
            Console.WriteLine(total);

            Console.ReadLine();
        }

        static int smallest(int x, int y, int z)
        {
            int c = 0;

            while (x > 0 & y > 0 & z > 0)
            {
                x--; y--; z--; c++;
            }
            return c;
        }

        //static Array findLHW(string line)
        //{
        //    int[] m = new int[3];

        //    m[0] = 
        //}

    }
}
