using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, result;
            Console.WriteLine("Enter first number");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            number2 = int.Parse(Console.ReadLine());

            result = number1 + number2;

            Console.WriteLine($"Sum is: {result}");
            Console.ReadLine();
        }
    }
}
