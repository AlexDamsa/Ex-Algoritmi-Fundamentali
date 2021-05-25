using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumAbsoluteDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, -2, 5, -4 };

            Console.WriteLine(MaximumAbsoluteDifference(array));
        }

        public static int MaximumAbsoluteDifference(int[] array)
        {
            int result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    int diff = Diff(i, j);
                    if (diff > result)
                    {
                        result = diff;
                    }
                }
            }

            return result;

            int Diff(int i, int j)
            {
                return Math.Abs(array[i] - array[j]) + Math.Abs(i - j);
            }
        }
    }
}
