using System;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
            int debt = 700;
            Console.WriteLine("Your current debt is {0:#}", debt);
            Console.WriteLine("Enter sum to pay off debt: ");
            int money = Int32.Parse(Console.ReadLine());

            Amortization(money, ref debt);

            //3
            //recursive calls are slower than iterative calls.
            //reusable method calls may overflow the system stack
            int N = 6;
            int resultRec = FactorialRec(N);
            Console.WriteLine("Number of options {0:#}", resultRec);

            //4
            Console.WriteLine("Enter the operand1 and operand2(Integer): ");
            int operand1 = Int32.Parse(Console.ReadLine());
            int operand2 = Int32.Parse(Console.ReadLine());
            long result;

            Console.WriteLine("Enter key for operation:\n" +
                              "r - remainder of division\n" +
                              "p - pow\n" +
                              "c - concatenationpcd\n" +
                              "d - division\n");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "r":
                    result = RemainderOfDivision(operand1, operand2);
                    Console.WriteLine("{0} % {1} = {2:#}", operand1, operand2, result);
                    break;
                case "p":
                    result = Pow(operand1, operand2);
                    Console.WriteLine("{0} ^ {1} = {2:G}", operand1, operand2, result);
                    break;
                case "c":
                    result = Concatenation(operand1, operand2);
                    Console.WriteLine("{0} + {1} = {2:#}", operand1, operand2, result);
                    break;
                case "d":
                    result = Division(operand1, operand2);
                    Console.WriteLine("{0} / {1} = {2:G}", operand1, operand2, result);
                    break;
                default:
                    Console.WriteLine("You entered another word");
                    break;
            }

            //5(additional task)
            double a = 5;
            double b = 8;
            double c = 34;
            Calculate(ref a, ref b, ref c);

            Console.WriteLine("Numbers after division by 5 : {0:#.##}; {1:#.##}; {2:#.##}", a, b,c);

            Console.ReadLine();
        }

        private static void Amortization(int sum, ref int debt)
        {
            debt -= sum;

            if (debt < 0)
            {
                Console.WriteLine("Debt repaid");
                Console.WriteLine("Overpayment amount: {0:#}", debt);
            }
            else if (debt > 0)
                Console.WriteLine("Amount due: {0:#}", debt);
            else
                Console.WriteLine("Debt repaid");
        }

        private static int FactorialRec(int n)
        {
            if (n == 0)
                return 1;
            return FactorialRec(n - 1) * n;
        }

        private static int RemainderOfDivision(int a, int b)
        {
            return a % b;
        }

        private static long Pow(int a, int b)
        {
            int res = 1;
            for (int i = 0; i < b; ++i)
                res *= a;
            return res;
        }

        private static int Concatenation(int a, int b)
        {
            string str = a.ToString() + b.ToString();
            int ab = Int32.Parse(str);
            return ab;
        }

        private static int Division(int a, int b)
        {
            if (b == 0)
            {
                Console.Write("Division by zero! ");
                return -1;
            }
            return a / b;
        }

        private static void Calculate(ref double a, ref double b, ref double c)
        {
            a /= 5;
            b /= 5;
            c /= 5;
        }
    }
}
