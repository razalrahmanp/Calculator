using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            char op;

            Console.WriteLine("Enter first number:");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter operator (+, -, *, /):");
            op = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            num2 = double.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("Result: " + result);
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine("Result: " + result);
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine("Result: " + result);
                    break;
                case '/':
                    result = num1 / num2;
                    Console.WriteLine("Result: " + result);
                    break;
                default: 
                    Console.WriteLine("Invalid Operator");
                    break;
            }

            Console.ReadLine();
        }
    }
}
