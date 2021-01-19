using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };

            IEnumerable<int> evens = numbers.Where(i => (i % 2 == 0) && (i > 10));

            foreach (int i in evens)
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
