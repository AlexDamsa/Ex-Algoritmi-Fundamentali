using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            array.Print();

            array.RotateLeft();

            array.Print();
        }
    }

    public static class ExtensionMethods
    {
        public static void RotateLeft<T>(this T[] instance)
        {
            T first = instance[0];
            for (int i = 0; i < instance.Length - 1; i++)
            {
                instance[i] = instance[i + 1];
            }
            instance[instance.Length - 1] = first;
        }

        public static void Print<T>(this T[] instance)
        {
            foreach (var x in instance)
            {
                Console.Write($"{x}\t");
            }
            Console.WriteLine();
        }
    }
}
