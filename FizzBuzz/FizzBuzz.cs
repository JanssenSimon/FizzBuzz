using System;

namespace FizzBuzz
{
    public static class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FizzBuzz.PlayTo(100));
        }

        public static string PlayTo(int max)
        {
            string output = "";
            for(int i = 1; i < max; i++)
                output += FizzBuzz.FromIndex(i) + "\n";
            output += FizzBuzz.FromIndex(max);
            return output;
        }

        public static string FromIndex(int index) 
        {
            string output = "";
            if(IsMultipleOf(3, index)) output += "Fizz";
            if(IsMultipleOf(5, index)) output += "Buzz";
            if(String.IsNullOrEmpty(output)) output += index.ToString();
            return output;
        }

        private static bool IsMultipleOf(int factor, int number)
        {
            return number % factor == 0;
        }
    }
}
