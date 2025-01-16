using System.ComponentModel;

namespace C._Simple_Calculator
{
    /// <summary>
    /// Given two numbers X and Y. Print the summation and multiplication and subtraction of these 2 numbers.

    //Input
        //Only one line containing two separated numbers X, Y(1  ≤  X, Y ≤  105).

    //Output
       // Print 3 lines that contain the following in the same order:

      //"X + Y = summation result" without quotes.
      //"X * Y = multiplication result" without quotes.
      //"X - Y = subtraction result" without quotes.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            long num1 = long.Parse(inputs[0]);
            long num2 = long.Parse(inputs[1]);  
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }
    }
}
