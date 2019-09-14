using System;

namespace ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a list of Numbers");
            var input = Console.ReadLine();
            var inputStrings = input.Split(",");

            if (inputStrings.Length >= 3)
            {
                foreach (var inputString in inputStrings)
                {
                    Console.WriteLine(inputString);
                }
            } else if (inputStrings.Length < 3)
            {
                Console.WriteLine("please enter at least 3 #'s");
            }
            //int.Parse();

            //Console.WriteLine($"You entered: {inputStrings}");

            //Console.ReadLine();
        }
    }
}
