using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenFibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FIB_TARGET = 4000000;

            List<int> sequence = new List<int>();

            // Fibonacci sequence
            int fib = 0, a = 0, b = 1;
            do
            {
                fib = a + b;
                a = b;
                b = fib;

                if (fib % 2 == 0) sequence.Add(fib);
            } while (fib <= FIB_TARGET);

            Console.WriteLine("Sum: {0}", sequence.Sum());
        }
    }
}
