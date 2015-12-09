using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = System.IO.File.ReadAllText(@"C:\Users\Erin\Desktop\Git\AdventOfCode\Day1\Pt1\Day1Input.txt");

            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    sum++;
                }
                else if (input[i] == ')')
                {
                    sum--;
                }

                if (sum < 0)
                {
                    //Console.WriteLine(sum + "-" + (i + 1));
                    Console.WriteLine(i + 1);
                    break;
                }
            }
            Console.ReadLine();


            #region PracticeLoop
            //Console.WriteLine("Enter Q to quit.");

            //while (true)
            //{
            //Console.WriteLine("Please enter input data:  ");
            //string input = Console.ReadLine();

            //int sum = 0;

            //if (input == "Q")
            //{
            //    break;
            //}

            //else
            //{
            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (input[i] == '(')
            //    {
            //        sum++;
            //    }
            //    else if (input[i] == ')')
            //    {
            //        sum--;
            //    }
            //}

            //Console.WriteLine("Santa, please proceed to floor " + sum);
            //}

            //Console.WriteLine();
            //Console.WriteLine("Press any key to continue...");
            //Console.ReadLine();
            //}
            #endregion
        }
    }
}
