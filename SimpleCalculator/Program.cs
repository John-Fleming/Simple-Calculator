using System;
using System.Linq;
using System.Text;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a mathermatical operator followed by a space and a commma separated list of numbers:");
            var operation = Console.ReadLine();

            var separateOperatorFromNums = operation.Split(' ');
            var mathOption = separateOperatorFromNums[0];
            var numbers = separateOperatorFromNums[1];

            var splitNumbers = numbers.Split(',');

            var multipliedNumbers = 1;
            var addNumbers = 0;
            var newSquaredNumbers = new StringBuilder();

            foreach (var n in splitNumbers)
            {
                var currentnum = int.Parse(n);

                if (mathOption == "*")
                {
                    multipliedNumbers *= currentnum;
                }

                else if (mathOption == "+")
                {
                    addNumbers += currentnum;
                }

                else if (mathOption == "^2")
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

            if (mathOption == "*")
            {
                Console.WriteLine($"Multiplying those numbers together totals: {multipliedNumbers}");
            }
            else if (mathOption == "^2")
            {
                Console.WriteLine($"Here's each number squared: {newSquaredNumbers}");
            }
            else if (mathOption == "+")
            {
                Console.WriteLine($"Adding those numbers together totals: {addNumbers}");
            }

            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();

        }
    }
}
