using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> a = new Stack<int>();
            Stack<int> b = new Stack<int>();
            Stack<int> c = new Stack<int>();

            int capacity = 3;
            for (int i = capacity; i >= 1; i--)
            {
                a.Push(i);
            }

            PrintPegs(a, b, c);
            towerOfHanoi(capacity, a, b, c);

            PrintPegs(a, b, c);
        }

        static void towerOfHanoi(int n, Stack<int> a, Stack<int> b, Stack<int> c)
        {
            if (n == 1)
            {
                MoveDisk(a, b);
                PrintPegs(a, b, c);
                return;
            }

            towerOfHanoi(n - 1, a, c, b);
            MoveDisk(a, b);
            PrintPegs(a, b, c);
            towerOfHanoi(n - 1, c, b, a);
            
            void MoveDisk(Stack<int> fromPeg, Stack<int> toPeg)
            {
                toPeg.Push(fromPeg.Pop());
            }
        }


        public static void PrintPegs(Stack<int> a, Stack<int> b, Stack<int> c)
        {
            int[] ra = a.Reverse().ToArray();
            int[] rb = b.Reverse().ToArray();
            int[] rc = c.Reverse().ToArray();

            Console.Write("A: ");
            foreach (var x in ra)
            {
                Console.Write($"{x}\t");
            }
            Console.WriteLine();

            Console.Write("B: ");
            foreach (var x in rb)
            {
                Console.Write($"{x}\t");
            }
            Console.WriteLine();

            Console.Write("C: ");
            foreach (var x in rc)
            {
                Console.Write($"{x}\t");
            }
            Console.WriteLine();

            Console.WriteLine();
        }
    }
}
