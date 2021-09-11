using System;

namespace AnagramProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Anagram anagram = new Anagram();

            Console.WriteLine("Enter your text");

            Console.WriteLine("Your text after processing: " + anagram.Reverse(Console.ReadLine()));
        }
    }
}
