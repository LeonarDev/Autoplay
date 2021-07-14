using System;
using System.Diagnostics;

namespace DotNetDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Fibonacci(6);
            Console.WriteLine(result);
            // Console.ReadKey(true);
        }
        static int Fibonacci(int n) {
            Debug.WriteLine($"Entering {nameof(Fibonacci)} method");
            Debug.WriteLine($"We are looking for the {n}nth number");
            int n1 = 0;
            int n2 = 1;
            int sum = 0;

            for (int i = 2; i <= n; i++) {
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;
                Debug.WriteLineIf(sum == 1, $"Sum = 1, n1 = {n1}, n2 = {n2}" );
                Debug.WriteLineIf(sum == 2, $"Sum = 2, n1 = {n1}, n2 = {n2}" );
                Debug.WriteLineIf(sum == 3, $"Sum = 3, n1 = {n1}, n2 = {n2}" );
                Debug.WriteLineIf(sum == 4, $"Sum = 4, n1 = {n1}, n2 = {n2}" );
                Debug.WriteLineIf(sum == 5, $"Sum = 5, n1 = {n1}, n2 = {n2}" );
                Debug.WriteLineIf(sum == 6, $"Sum = 6, n1 = {n1}, n2 = {n2}" );
            }
            // if n2 is 5 continue. else break.
            Debug.Assert(n2 == 5, "The returned value is not 5 and it should be");
            return n == 0 ? n1 : n2;
        }
    }
}