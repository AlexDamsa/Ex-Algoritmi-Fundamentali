using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateImage
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 }
            };

            matrix.Print();
            
            RotateImage(matrix);

            Console.WriteLine();
            matrix.Print();
        }

        static void RotateImage(int[,] matrix)
        {
            int length = matrix.GetLength(0);

            for (int t = 0; t < length / 2; t++)
            {
                for (int i = t; i < length - t - 1; i++)
                {
                    int temp = matrix[t, i];
                    matrix[t, i] = matrix[i, length - 1 - t];
                    matrix[i, length - 1 - t] = matrix[length - 1 - t, length - 1 - i];
                    matrix[length - 1 - t, length - 1 - i] = matrix[length - 1 - i, t];
                    matrix[length - 1 - i, t] = temp;
                }
            }
        }
    }

    static class ExtensionMethods
    {
        public static void Print<T>(this T[,] instance)
        {
            for (int i = 0; i < instance.GetLength(0); i++)
            {
                for (int j = 0; j < instance.GetLength(1); j++)
                {
                    Console.Write($"{instance[i,j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}