using System;

namespace SumOf3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number.");
            double first = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your second number.");
            double second = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your third number.");
            double third = Convert.ToDouble(Console.ReadLine());

            double sum = first + second + third;

            Console.WriteLine("The sum is " + sum);

            const double value = 7.777;

            double multiply = value * sum;

            Console.WriteLine($"The sum times 7.777 is {multiply.ToString("N3")}");
        }
    }
}
