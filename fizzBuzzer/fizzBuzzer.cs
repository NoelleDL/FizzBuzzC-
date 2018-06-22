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
            else 
            {
                string output = input.ToString();
                return output;
            }

        }
    }
}
