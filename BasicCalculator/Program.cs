using System;
using System.Globalization;
namespace BasicCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                             Welcome to the calculator");
            Console.WriteLine("It is capable of performing calculations with both real numbers and integers");
            Console.ReadKey();
            Options();
        }
        public static void Options()
        {
            Console.Clear();
            Console.WriteLine("Enter the option you want to run:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Division");
            Console.WriteLine("4 - Multiplication");
            Console.WriteLine("5 - Exit calculator");
            try
            {
                int optionsCalculator = int.Parse(Console.ReadLine());

                switch (optionsCalculator)
                {
                    case 1: Addition(); break;
                    case 2: Subtraction(); break;
                    case 3: Division(); break;
                    case 4: Multiplication(); break;
                    case 5: System.Environment.Exit(0); break;
                    default: Options(); break;
                }
            }
            catch
            {
                Console.WriteLine("The value must be an integer");
                Console.ReadKey();
                Options();
            }
        }
        static void Addition()
        {
            Console.Clear();
            Console.WriteLine("Enter the first value: ");
            try
            {
                double firstValue = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.WriteLine("Enter the second value: ");
                double secondValue = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                double result = firstValue + secondValue;
                Console.WriteLine("The sum of these values is = " + result.ToString("F2", CultureInfo.InvariantCulture));
                Console.ReadKey();
                Options();
            }
            catch
            {
                Console.WriteLine("Both values must be a integer or real");
                Console.ReadKey();
                Options();
            }
        }
        static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("Enter the first value: ");
            try
            {
                double firstValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Enter the second value: ");
                double secondValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double result = firstValue - secondValue;
                Console.WriteLine("The subtraction of these values is = " + result.ToString("F2", CultureInfo.InvariantCulture));
                Console.ReadKey();
                Options();
            }
            catch
            {
                Console.WriteLine("Both values must be a integer or real");
                Console.ReadKey();
                Options();
            }
        }
        static void Division()
        {
            Console.Clear();
            Console.WriteLine("Enter the first value: ");
            try
            {
                double firstValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Enter the second value: ");
                double secondValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double result = firstValue / secondValue;
                Console.WriteLine("The division of these values is = " + result.ToString("F2", CultureInfo.InvariantCulture));
                Console.ReadKey();
                Options();
            }
            catch
            {
                Console.WriteLine("Both values must be a integer or real");
                Console.ReadKey();
                Options();
            }
        }
        static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("Enter the first value: ");
            try
            {
                double firstValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Enter the second value: ");
                double secondValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double result = firstValue * secondValue;
                Console.WriteLine("The multiplication of these values is = " + result.ToString("F2", CultureInfo.InvariantCulture));
                Console.ReadKey();
                Options();
            }
            catch
            {
                Console.WriteLine("Both values must be a integer or real");
                Console.ReadKey();
                Options();
            }
        }
    }
}
