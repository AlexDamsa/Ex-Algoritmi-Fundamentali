using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            do
            {
                Console.Write("n: ");
            } while (!int.TryParse(Console.ReadLine(), out input));

            Console.WriteLine(Fibonacci(input));
        }

        public static int Fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n <= 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
