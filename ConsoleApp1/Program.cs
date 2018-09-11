using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public FizzBuzzer()
        {
        }


        public void FizzBuzz(int number)
        {
            var fizzbuzzes = new List<string>();
            //delegate void constructStringRule(string text, List<String> existingArray);

            Action stringRule = () => fizzbuzzes.Add("Fizz");
            Dictionary<int, Action> rules = new Dictionary<int, Action>
            {
                {3, stringRule}
            };
            foreach (KeyValuePair<int, Action> rule in rules)
            {
                if (this.Divisible(number, rule.Key))
                {
                    rule.Value.Invoke();
                }

            }
            // if (this.Divisible(number, 3))
            // {
            //     this.stringRule("Fizz", fizzbuzzes);
            // }
            // else
            // {
            //     this.stringRule("Buzz", fizzbuzzes);
            // }
            string fizzBuzzOutput = String.Join(String.Empty, fizzbuzzes);
            System.Console.WriteLine(fizzBuzzOutput);
        }
            
        private bool Divisible(int number, int divisor)
        {
             bool divisible = (number % divisor == 0);
             return divisible;
        }

        //private void stringRule(string text, List<String> existingArray)
        //{
        //    existingArray.Add(text);
        //}
     }
    class TestFizzBuzz
    {
        static void Main()
        {
            var fizzbuzzer = new FizzBuzzer();
            for (int i = 1; i < 100; i++)
            {
                fizzbuzzer.FizzBuzz(i);
            }
            Console.ReadKey();
        }
    }
}
