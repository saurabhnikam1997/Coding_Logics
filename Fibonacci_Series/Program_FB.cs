using System;

namespace Fibonacci_Series
{
    public class Program_FB
    {
        private static long[] FibCache;
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            FibCache = new long[num+1];

            // To return exact nth fibonacci number
            long nums = FibonacciNum(num);
            Console.WriteLine(nums);

            // To return List of Numbers

            for (int i = 0; i < num + 1; i++)
            {
                long number = FibonacciNum(i);
                Console.Write(number + ",");
            }

            Console.ReadLine();
        }

        // f(n) = f(n-1) + f(n-2)
        private static long FibonacciNum(int n)
        {
            // for 0 and 1
            if (n <= 1)
                return n;

            // for caching
            if (FibCache[n] != 0)
            {
                return FibCache[n];
            }

            // actual logic call backs
            long nthFibNum = FibonacciNum(n - 1) + FibonacciNum(n - 2);

            FibCache[n] = nthFibNum;
            return nthFibNum;
        }
    }
}
