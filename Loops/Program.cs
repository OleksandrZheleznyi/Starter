using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
            int A = 10;
            int B = 15;
            int result = 0;
            for (int i = A; i <= B; ++i)
            {
                result += i;
            }
            Console.WriteLine("Sum between A and B = {0:#}", result);
            for (int i = A; i <= B; ++i)
            {
                if (i % 2 != 0)
                    Console.WriteLine("Odd number between A and B = {0:#}", i);
            }
            Console.Write("\n");
            //3
            int size = 5;
            //rectangle
            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                    Console.Write("*");
                Console.Write("\n");
            }
            Console.Write("\n");
            //right triangle
            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < i + 1; ++j)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            //equilateral triangle
            for (int i = 1; i <= size; i += 2)
            {
                for (int j = 0; j < (size - i) / 2; ++j)
                    Console.Write(" ");
                for (int k = 0; k < i; ++k)
                    Console.Write("*");
                Console.Write("\n");
            }
            Console.Write("\n");
            //rhombus
            for (int i = 1; i <= size; i += 2)
            {
                for (int j = 0; j < (size - i) / 2; ++j)
                    Console.Write(" ");
                for (int k = 0; k < i; ++k)
                    Console.Write("*");
                Console.Write("\n");
            }
            for (int i = 2; i < size; i += 2)
            {
                for (int j = 0; j < i - j; ++j)
                    Console.Write(" ");
                for (int k = 0; k < size - i; ++k)
                    Console.Write("*");
                Console.Write("\n");
            }
            Console.Write("\n");
            //4
            int N = 5;
            int resultF = 1;
            do
            {
                resultF *= N;
                --N;
            }
            while (N!=0);

            Console.WriteLine("There are ways = {0:#}", resultF);

            Console.Write("\n");

            //5(additional task)
            int height = 5;
            int width = 7;
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    if ((i > 0 && i < height - 1) && (j > 0 && j < width - 1))
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
