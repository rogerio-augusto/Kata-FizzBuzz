using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var number = 1; number <= 100; number++)
            {
                Console.WriteLine(FizzBuzzGame.SayFizzBuzz(number));
            }

            Console.WriteLine("...");
            Console.ReadLine();
        }
    }
}
