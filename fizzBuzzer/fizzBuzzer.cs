using System;

namespace fizzBuzz.Library
{
    public class fizzBuzzer 
    {
        public static string GetValue(int input)
        {
            if (input % 15 == 0) 
            {
                return "FizzBuzz";
            }
            else if (input % 3 == 0)
            {
                return "Fizz";
            }
            else if (input % 5 == 0)
            {
                return "Buzz";
            }
            else 
            {
                string output = input.ToString();
                return output;
            }

        }
    }
}
