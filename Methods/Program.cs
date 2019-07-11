using System;

namespace Methods
{
    class Program
    {
        static double Add(double a, double b)
        {
            return a + b;
        }
        static double Sub(double a, double b)
        {
            return a - b;
        }
        static double Mul(double a, double b)
        {
            return a * b;
        }
        static double Div(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division by zero");
                return Double.NaN;
            }
            return a / b;
        }
        static double MoneyConversion(double m, double r)
        {
            return m / r;
        }
        static bool IsPositive(int p)
        {
            return p >= 0;
        }
        static bool IsPrime(int p)
        {
            for (int i = 2; i < Math.Sqrt(p); ++i)
            {
                if (p % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsDivided(int p)
        {
            if (p % 2 == 0 || p % 5 == 0 || p % 3 == 0 || p % 6 == 0 || p % 9 == 0)
                return true;
            else
                return false;
        }
        static void Calculate(int a, int b, int c)
        {
            int average = (a + b + c) / 3;
            Console.WriteLine("Average of {0} {1} {2} is {3}", a, b, c, average);
        }
        static void Main(string[] args)
        {
            //2
            double result;

            Console.WriteLine("Enter the operand1 and operand2: ");
            double operand1 = Double.Parse(Console.ReadLine());
            double operand2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the sign of the arithmetic operation:");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    result = Add(operand1, operand2);
                    Console.WriteLine("{0} {1} {2} = {3:#.###}", operand1, sign, operand2, result);
                    break;
                case "-":
                    result = Sub(operand1, operand2);
                    Console.WriteLine("{0} {1} {2} = {3:#.###}", operand1, sign, operand2, result);
                    break;
                case "*":
                    result = Mul(operand1, operand2);
                    Console.WriteLine("{0} {1} {2} = {3:#.###}", operand1, sign, operand2, result);
                    break;
                case "/":
                    result = Div(operand1, operand2);
                    Console.WriteLine("{0} {1} {2} = {3:#.###}", operand1, sign, operand2, result);
                    break;
                default:
                    Console.WriteLine("You entered a non-existing sign");
                    break;
            }
        
            //3
            Console.WriteLine("Enter the sum for conversion: ");
            double money = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter currency rate(can not be 0): ");
            double rate = Double.Parse(Console.ReadLine());

            double res = MoneyConversion(money, rate);
            Console.WriteLine("Money money in another currency {0:#.###}", res);
            
            //4
            Console.WriteLine("Enter number: ");
            int num = Int32.Parse(Console.ReadLine());

            if (IsPositive(num))
                Console.WriteLine("Number is positive");
            else
                Console.WriteLine("Number is negative");

            if (IsPrime(num))
                Console.WriteLine("Number is prime");
            else
                Console.WriteLine("Number is not prime");

            if (IsDivided(num))
                Console.WriteLine("Number is divided");
            else
                Console.WriteLine("Number is not divided");
          
            //5(additional task)
            Calculate(3, 7, 5);

            Console.ReadLine();
        }
    }
}
