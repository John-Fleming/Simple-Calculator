using System;
using System.Linq;
using System.Text;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a commma separated list of numbers:");
            var numbers = Console.ReadLine();
            
            Console.WriteLine("Multiply or Square these numbers?");
            var mathOption = Console.ReadLine();

            var splitNumbers = numbers.Split(',');

            var multipliedNumbers = 1;
            var newSquaredNumbers = new StringBuilder();

            foreach (var n in splitNumbers)
            {
                var currentnum = int.Parse(n);

                if (mathOption == "Multiply")
                {
                    multipliedNumbers *= currentnum;
                }
                else if (mathOption == "Square")
                {
                    var result = currentnum * currentnum;
                    if (n == splitNumbers[0])
                    {
                        newSquaredNumbers.Append($"{result}");
                    }
                    else
                    {
                        newSquaredNumbers.Append($",{result}");
                    }
                }
            }

            if (mathOption == "Multiply")
            {
                Console.WriteLine($"Multiplying those numbers together totals: {multipliedNumbers}");
            }
            else if (mathOption == "Square")
            {
                Console.WriteLine($"Here's each number squared: {newSquaredNumbers}");
            }
        }
    }
}
