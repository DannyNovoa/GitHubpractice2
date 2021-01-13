using System;

namespace GitHubpractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence: ");

            string sentence = Console.ReadLine();

            int wordCount = CountWords(sentence);

            Console.WriteLine($"We have {wordCount} in your input. ");

            Console.ReadKey();

        }

        static int CountWords(string sentences)
        {
            int wordCount = sentences.Split(' ').Length;


            return wordCount;

            
        }
        

    }
}
