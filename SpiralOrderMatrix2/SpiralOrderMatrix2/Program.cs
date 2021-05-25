using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralOrderMatrix2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;

            int[,] matrix = SpiralOrderMatrix2(a);

            matrix.Print();
        }

        public static int[,] SpiralOrderMatrix2(int num)
        {
            if (num < 0)
            {
                return null;
            }

            int startRow = 0;
            int startColumn = 0;
            int endRow = num;
            int endColumn = num;

            int currentNumber = 1;

            int[,] matrix = new int[num, num];

            while(startRow < endRow && startColumn < endColumn)
            {
                for (int i = startColumn; i < endColumn; i++)
                {
                    matrix[startRow, i] = currentNumber;
                    currentNumber++;
                }
                startRow++;

                for (int i = startRow; i < endRow; i++)
                {
                    matrix[i, endColumn - 1] = currentNumber;
                    currentNumber++;
                }
                endColumn--;

                if (startRow < endRow)
                {
                    for (int i = endColumn - 1; i >= startColumn; i--)
                    {
                        matrix[endRow - 1, i] = currentNumber;
                        currentNumber++;
                    }
                    endRow--;
                }

                if (startColumn < endColumn)
                {
                    for (int i = endRow - 1; i >= startRow; i--)
                    {
                        matrix[i, startColumn] = currentNumber;
                        currentNumber++;
                    }
                    startColumn++;
                }
            }

            return matrix;
        }
    }
}

public static class ExtensionMethods
{
    public static void Print<T>(this T[,] instance)
    {
        for (int i = 0; i < instance.GetLength(0); i++)
        {
            for (int j = 0; j < instance.GetLength(1); j++)
            {
                Console.Write($"{instance[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
}
