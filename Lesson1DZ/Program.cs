using System;

namespace Lesson1DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am Igor Polivin");
            int num1, num2;
            Console.WriteLine("Enter first number: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Summa = {num1 + num2 }");
        }
    }
}
