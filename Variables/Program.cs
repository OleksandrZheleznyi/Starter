using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int x = 10;
            int y = 12;
            int z = 3;

            x += y - x++ * z;//-8
            z = --x - y * 5;//-69 
            y /= x + 5 % z;//-3
            z = x++ + y * 5;//-24 
            x = y - x++ * z;//-195

            Console.WriteLine("x = {0}", x);
            Console.WriteLine("y = {0}", y);
            Console.WriteLine("z = {0}", z);

            //2
            int a = 6, b = 7, c = 10;
            float average;
            //Need sum to float(double) for best result
            average = (float)(a + b + c) / 3;
            Console.WriteLine("average = {0:#.##}", average);

            //3
            double pi = Math.PI;
            int r = 5;
            double square;
            square = pi * Math.Pow(r, 2);
            Console.WriteLine("square = {0:#.###}", square);

            //4
            int R = 6;
            int h = 5;
            double V;
            double S;
            V = pi * R * R * h;
            S = 2 * pi * R * (R + h);
            Console.WriteLine("V = {0:#.###}", V);
            Console.WriteLine("S = {0:#.###}", S);

            //5
            //int uberflu?;//It is impossible
            int _Identifier;
            int \u006fIdentifier;
            //int &myVar;
            int myVariab1le;//It is impossible

            //6
            //Operators
            https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/operators

            //Cast and Type Conversion
            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions

            //Math.PI Field
            https://docs.microsoft.com/en-us/dotnet/api/system.math.pi?view=netframework-4.8

            //To prevent the console from closing
            Console.ReadLine();
        }
    }
}
