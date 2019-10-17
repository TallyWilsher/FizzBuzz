using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            
            List <int> userInput = new List<int>();
            
            do
            {
                i++;
                userInput.Add(i);
            } while (i < 100);
            

            foreach(int x in userInput)
            {
                if (x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (x % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (x % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(x);
                }

            }

        }
    }
}
