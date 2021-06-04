using System;
using System.Threading.Tasks;

namespace _3_SerialAndParallelCall
{
    class Program
    {
        static void Factorial(int n)
        {
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Factorial {n} is equal to the {result}");
        }
        static async void FactorialAsync()
        {
            //await Task.Run(() => Factorial(4));
            //await Task.Run(() => Factorial(5));
            //await Task.Run(() => Factorial(6));

            Task t1 = Task.Run(() => Factorial(4));
            Task t2 = Task.Run(() => Factorial(5));
            Task t3 = Task.Run(() => Factorial(6));
            await Task.WhenAll(new[] { t1, t2, t3 });
        }

        static void Main(string[] args)
        {
            FactorialAsync();
            Console.Read();
        }
    }
}
