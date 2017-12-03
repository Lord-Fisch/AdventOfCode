using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Format("Day 1 Part 1: {0}", Day1.Part1()));
            Console.WriteLine(string.Format("Day 1 Part 2: {0}", Day1.Part2()));
            Console.WriteLine();
            Console.WriteLine(string.Format("Day 2 Part 1: {0}", Day2.Part1()));
            Console.WriteLine(string.Format("Day 2 Part 2: {0}", Day2.Part2()));
            Console.WriteLine();
            Console.WriteLine(string.Format("Day 3 Part 1: {0}", Day3.Part1()));
            //Console.WriteLine(string.Format("Day 3 Part 2: {0}", Day3.Part2()));

            Console.ReadKey();
        }
    }
}
