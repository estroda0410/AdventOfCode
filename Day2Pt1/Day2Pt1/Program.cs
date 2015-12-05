using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Pt1
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = System.IO.File.ReadAllText(@"C:\Users\Erin\Desktop\Git\AdventOfCode\Day2Pt1\Day2Input.txt");

            Console.WriteLine("Contents of txt = {0}", text);

            Console.ReadLine();
        }
    }
}
