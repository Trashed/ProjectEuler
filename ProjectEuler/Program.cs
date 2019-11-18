using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                numbers.Add(i);
            }

            // Use an anonymous function to get all multiples of three and five
            var sum = numbers.Select(x => x).Where(x => x % 3 == 0 || x % 5 == 0).Sum();

            Console.WriteLine("Sum of multiples: {0}", sum);
        }
    }
}
