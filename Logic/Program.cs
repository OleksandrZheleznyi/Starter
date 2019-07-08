using System;

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
            int a = 4;
            int b = 5;
            //2.1
            if (a % 2 == 0)
                Console.WriteLine("Even number");
            else
                Console.WriteLine("Odd number");
            //2.2
            int res = b & 1;
            if (res == 0)
                Console.WriteLine("Even number");
            else
                Console.WriteLine("Odd number");

            //3
            int x = 5, y = 10, z = 15;

            x += y >> x++ * z;//5 
            z = ++x & y * 5;//2 
            y /= x + 5 | z;//0 
            z = x++ & y * 5;//0 
            x = y << x++ ^ z;//0

            Console.WriteLine("x = {0:G}", x);
            Console.WriteLine("y = {0:G}", y);
            Console.WriteLine("z = {0:G}", z);

            //4
            double salary = 100;
            int years = 17;

            if (years < 5)
                salary += salary * 0.1;
            else if (years >= 5 && years < 10)
                salary += salary * 0.15;
            else if (years >= 10 && years < 15)
                salary += salary * 0.25;
            else if (years >= 15 && years < 20)
                salary += salary * 0.35;
            else if (years >= 20 && years < 25)
                salary += salary * 0.4;
            else if (years >= 25)
                salary += salary * 0.5;

            Console.WriteLine("salary after {0} years = {1:#.##}", years, salary);

            //5(additional task)
            int f = 8;
            
            //bit twiddling hacks
            //formula
            //bool isPowerOfTwo = f && !(f & (f - 1));

            bool isPowerOfTwo = (f != 0) && ((f & (f - 1)) == 0);

            if (isPowerOfTwo)
                Console.WriteLine("Power of two");
            else
                Console.WriteLine("Not power of two");

            Console.ReadLine();
        }
    }
}
