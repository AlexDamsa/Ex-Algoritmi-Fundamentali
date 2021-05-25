using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 15 };

            array.Print();
            Console.WriteLine(array.SimpleArraySum());
        }
    }

    static class ExtansionMethods
    {
        public static int SimpleArraySum(this int[] instance)
        {
            int sum = 0;
            foreach (var x in instance)
            {
                sum += x;
            }

            return sum;
        }

        public static void Print(this int[] instance)
        {
            foreach (var x in instance)
            {
                Console.Write($"{x}\t");
            }
            Console.WriteLine();
        }
    }
}
