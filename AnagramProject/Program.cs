using System;

namespace AnagramProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Anagram converter = new Anagram();

            string userString;
            string result;

            Console.WriteLine("Enter your text");

            userString = Console.ReadLine();

            result = converter.Reverse(userString);

            Console.WriteLine("Your text after processing: " + result);
        }
    }
}
