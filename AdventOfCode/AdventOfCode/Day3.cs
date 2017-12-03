using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Day3
    {
        //private const int input = 312051;
        private const int input = 12;

        public static int Part1()
        {
            int closestSquare = getClosestOddSquare(input);
            int closestSqrt = (int)Math.Sqrt(closestSquare);

            Console.WriteLine(getClosestOddSquare(1));
            Console.WriteLine(getClosestOddSquare(2));
            Console.WriteLine(getClosestOddSquare(3));
            Console.WriteLine(getClosestOddSquare(9));
            Console.WriteLine(getClosestOddSquare(12));

            return 0;
        }

        private static int getClosestOddSquare(int n)
        {
            if (Math.Ceiling(Math.Sqrt(n)) % 2 == 0)
                return (int)Math.Ceiling(Math.Sqrt(n)) + 1;
            else
                return (int)Math.Ceiling(Math.Sqrt(n));
        }
    }
}
