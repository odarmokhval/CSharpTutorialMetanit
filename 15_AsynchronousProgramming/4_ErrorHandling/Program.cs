using System;
using System.Threading.Tasks;

namespace _4_ErrorHandling
{
    class Program
    {
        static void Factorial(int n)
        {
            if (n < 1)
                throw new Exception($"{n}: number should not be less than 1");

            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Factorial {n} is equal to the {result}");
        }

        static async void FactorialAsync(int n)
        {

            //try
            //{
            //    await Task.Run(() => Factorial(n));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            Task task = null;
            try
            {
                await Task.Run(() => Factorial(n));
            }
            catch (Exception ex)
            {
                await Task.Run(() => Console.WriteLine(ex.Message));
            }
            finally
            {
                await Task.Run(() => Console.WriteLine($"IsFaulted: {task.IsFaulted}"));
            }
        }

        static async Task DoMultipleAsync()
        {
            Task allTasks = null;
            try
            {
                Task t1 = Task.Run(() => Factorial(-4));
                Task t2 = Task.Run(() => Factorial(-5));
                Task t3 = Task.Run(() => Factorial(-6));
                allTasks = Task.WhenAll(new[] { t1, t2, t3 });
                await allTasks;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                Console.WriteLine($"IsFaulted: {allTasks.IsFaulted}");

                foreach (var inx in allTasks.Exception.InnerExceptions)
                {
                    Console.WriteLine("Inner exeption: " + inx.Message);
                }
            }

        }

        static void Main(string[] args)
        {
            //FactorialAsync(-1);
            //FactorialAsync(6);
            DoMultipleAsync();
            Console.Read();
        }
    }
}
