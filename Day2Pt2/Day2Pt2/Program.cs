using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* The elves are also running low on ribbon. Ribbon is all the same width, 
             * so they only have to worry about the length they need to order, 
             * which they would again like to be exact.

             * The ribbon required to wrap a present is the shortest distance around its sides, 
             * or the smallest perimeter of any one face. Each present also requires a bow made 
             * out of ribbon as well; the feet of ribbon required for the perfect bow is equal 
             * to the cubic feet of volume of the present. Don't ask how they tie the bow, though; 
             * they'll never tell.

             * For example:

             * A present with dimensions 2x3x4 requires 2+2+3+3 = 10 feet of ribbon to wrap the present 
             * plus 2*3*4 = 24 feet of ribbon for the bow, for a total of 34 feet.
             * A present with dimensions 1x1x10 requires 1+1+1+1 = 4 feet of ribbon to wrap the present 
             * plus 1*1*10 = 10 feet of ribbon for the bow, for a total of 14 feet.
             
             * How many total feet of ribbon should they order?
             */
            
            
            int total = 0;
            string line;

            StreamReader file = new StreamReader(@"C:\Users\Erin\Desktop\Git\AdventOfCode\Day2Pt1\Day2Input.txt");

            while ((line = file.ReadLine()) != null)
            {
                int perimeter = 0;
                int cV = 0;
                int ribbon = 0;

                int endW = line.IndexOf("x");
                int beginH = endW + 1;
                int endH = line.LastIndexOf("x");
                int beginL = endH + 1;

                int w = Convert.ToInt16(line.Substring(0, endW));
                int h = Convert.ToInt16(line.Substring(beginH, (endH - beginH)));
                int l = Convert.ToInt16(line.Substring(beginL, (line.Length - beginL)));

                int[] m = new int[3] { w, h, l };

                Array.Sort(m);


                int l1 = m[0];
                int l2 = m[1];

                perimeter = ((l1 * 2) + (l2 * 2));
                cV = w * h * l;
                ribbon = perimeter + cV;
                total = total + ribbon;

                //Console.WriteLine((string.Join(",", m)) + "-" + perimeter + "-" + cV + "-" + ribbon + "-" + total);
            }

            Console.WriteLine(total);
            Console.ReadLine();

        }
    }
}
