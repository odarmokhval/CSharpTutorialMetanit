using System;
using System.Threading;
using System.Threading.Tasks;

namespace _5_CancellationAsyncOperations
{
    class Program
    {
        static void Factorial(int n, CancellationToken tocken)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                if (tocken.IsCancellationRequested)
                {
                    Console.WriteLine("Operation is canceled by tocken");
                    return;
                }
                result *= i;
            }
            Console.WriteLine($"Factorial {n} is equal to the {result}");
            Thread.Sleep(1000);
        }

        static async void FactorialAsync(int n, CancellationToken tocken)
        {
            if (tocken.IsCancellationRequested)
            return;
            await Task.Run(() => Factorial(n, tocken));
        }

        static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken tocken = cts.Token;
            FactorialAsync(6, tocken);
            Thread.Sleep(3000);
            cts.Cancel();
            Console.Read();
        }
    }
}
