using System;

namespace IntroGithub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            
            Console.WriteLine("<<<WELCOME TO SUM PROGRAM>>>");
            Console.WriteLine("Please enter integer values");

            Console.WriteLine("Enter a value for a");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for b");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Subtracting {a} - {b} equals {SubtractNumbers(a, b)}");
        }

        public static int SubtractNumbers(int a, int b)
        {
            return a*b;
        }
    }

}
