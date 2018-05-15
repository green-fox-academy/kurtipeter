using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me something to calculate in the following form: \"+ x y\"");
            string userInput = Console.ReadLine();
            Console.WriteLine(Calculate(userInput));
            Console.ReadLine();
        }

        public static string Calculate(string input)
        {
            string[] splitInput = input.Split();
            string calcOperator = splitInput[0];
            int firstNumber = Int32.Parse(splitInput[1]);
            int secondNumber = Int32.Parse(splitInput[2]);

            if ("+" == calcOperator)
            {
                int solution = firstNumber + secondNumber;
                return "The answer is: " + solution;
            }
            else if ("-" == calcOperator)
            {
                int solution = firstNumber - secondNumber;
                return "The answer is: " + solution;
            }
            else if ("*" == calcOperator)
            {
                int solution = firstNumber * secondNumber;
                return "The answer is: " + solution;
            }
            else if ("/" == calcOperator)
            {
                if (secondNumber != 0)
                {
                    double solution = Convert.ToDouble(firstNumber) - secondNumber;
                    return "The answer is: " + solution;
                }
                else
                {
                    return "You are not allowed to make division with 0";
                }
            }
            else if ("%" == calcOperator)
            {
                int solution = firstNumber - secondNumber;
                return "The answer is: " + solution;
            }
            else
            {
                return "Your form was not valid, try again with using the right form this time.";
            }

        }
    }
}
