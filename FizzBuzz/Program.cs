using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double number))
            {
                Console.WriteLine(FizzBuzz(number));
            }
            else
            {
                Console.WriteLine("NaN");
            }

            Console.WriteLine(FizzBuzz(3));
            Console.WriteLine(FizzBuzz(5));
            Console.WriteLine(FizzBuzz(15));
            Console.WriteLine(FizzBuzz(7));
        }

        static string FizzBuzz(double input)
        {
            if (input % 3 == 0 && input % 5 == 0)
                return "FizzBuzz";

            if (input % 3 == 0)
                return "Fizz";

            if (input % 5 == 0)
                return "Buzz";

            return input.ToString();
        }
    }
}
