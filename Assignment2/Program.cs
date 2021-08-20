using System;
using System.IO;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number for which you want to find pair: ");
            var input = Console.ReadLine();

            var path = @"..\..\..\..\number.txt";

            var numbers = File.ReadAllText(path).Split(", ");

            var count = 0;
            foreach (var n in numbers)
            {
                if (n == input)
                    count++;
            }

            var result = count / 2;
            Console.WriteLine("Pair of {0} is {1}", input, result);
        }
    }
}
