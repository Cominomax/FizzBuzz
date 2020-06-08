using System;
using System.Linq;
using static System.Console;
namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Enumerable.Range(1, 100).ToArray();

            foreach (var number in sequence)
            {
                Write(number switch
                {
                    int i when (number % 3 == 0 && number % 5 == 0) => "FizzBuzz",
                    int i when (number % 3 == 0) => "Fizz",
                    int i when (number % 5 == 0) => "Buzz",
                    _ => number.ToString()
                });
                Write(" ");
            }
        }
    }
}
