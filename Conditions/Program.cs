using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
            double operand1 = 15;
            double operand2 = 0;
            double result;

            Console.WriteLine("Enter the sign of the arithmetic operation:");

            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    result = operand1 + operand2;
                    Console.WriteLine("operand1 {0} operand2 = {1:#.###}", sign, result);
                    break;
                case "-":
                    result = operand1 - operand2;
                    Console.WriteLine("operand1 {0} operand2 = {1:#.###}", sign, result);
                    break;
                case "*":
                    result = operand1 + operand2;
                    Console.WriteLine("operand1 {0} operand2 = {1:#.###}", sign, result);
                    break;
                case "/":
                    result = operand2 == 0 ? Double.NaN : operand1 / operand2;
                    Console.WriteLine("operand1 {0} operand2 = {1:#.###}", sign, result);
                    break;
                default:
                    Console.WriteLine("You entered a non-existing sign");
                    break;
            }

            //3
            Console.WriteLine("Enter a number between 0 and 100:");

            string userInput = Console.ReadLine();
            int number = Convert.ToInt32(userInput);

            if (0 <= number && number <= 14)
                Console.WriteLine("the number is between 0 and 14");
            else if (15 <= number && number <= 35)
                Console.WriteLine("the number is between 15 and 35");
            else if (36 <= number && number <= 50)
                Console.WriteLine("the number is between 36 and 50");
            else if (51 <= number && number <= 100)
                Console.WriteLine("the number is between 51 and 100");
            else
                Console.WriteLine("The number is not between 0 and 100");

            //4(additional task)
            Console.WriteLine("Enter a word about the weather in Russian:");

            string word = Console.ReadLine();

            switch (word)
            {
                case "дождь":
                    Console.WriteLine("{0} translete to English - rain", word);
                    break;
                case "снег":
                    Console.WriteLine("{0} translete to English - snow", word);
                    break;
                case "гроза":
                    Console.WriteLine("{0} translete to English - thunderstorm", word);
                    break;
                case "ветер":
                    Console.WriteLine("{0} translete to English - wind", word);
                    break;
                case "солнце":
                    Console.WriteLine("{0} translete to English - the sun", word);
                    break;
                case "холодно":
                    Console.WriteLine("{0} translete to English - cold", word);
                    break;
                case "мороз":
                    Console.WriteLine("{0} translete to English - frost", word);
                    break;
                case "жара":
                    Console.WriteLine("{0} translete to English - heat", word);
                    break;
                case "облака":
                    Console.WriteLine("{0} translete to English - the clouds", word);
                    break;
                case "туман":
                    Console.WriteLine("{0} translete to English - fog", word);
                    break;
                default:
                    Console.WriteLine("There is no translation for this word");
                    break;
            }

            Console.ReadLine();
        }
    }
}
