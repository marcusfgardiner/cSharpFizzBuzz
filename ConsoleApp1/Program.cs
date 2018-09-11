using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzer
     {
        public void FizzBuzz(int number)
        {
            string fizzBuzzOutput = "Fizz";
            if (number == 3)
            {
                fizzBuzzOutput = "Fizz";
            }
            else
            {
                fizzBuzzOutput = "Buzz";
            }
            System.Console.WriteLine(fizzBuzzOutput);
        }
     }
    class TestFizzBuzz
    {
        static void Main()
        {
            var fizzbuzzer = new FizzBuzzer();
            fizzbuzzer.FizzBuzz(3);
            fizzbuzzer.FizzBuzz(5);
            Console.ReadKey();
        }
    }
}
