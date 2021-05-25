using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddOneToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };

            array.Print();

            AddOne(ref array);

            array.Print();
        }

        static void AddOne(ref int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] == 9)
                {
                    array[i] = 0;
                }
                else
                {
                    array[i]++;
                    return;
                }
            }

            if (array[0] == 0)
            {
                Array.Resize(ref array, array.Length + 1);

                for (int i = array.Length - 1; i > 0; i--)
                {
                    array[i] = array[i - 1];
                }
                array[0] = 1;
            }
        }
    }

    public static class ExtensionMethods
    {
        public static void Print<T>(this T[] instnace)
        {
            foreach (var x in instnace)
            {
                Console.Write($"{x}\t");
            }
            Console.WriteLine();
        }
    }
}
