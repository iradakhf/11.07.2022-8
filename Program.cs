using System;
namespace ConsoleApp36
{
    class Program
    {
        public static void Main(string[] args)
        {
            Splitting splitting = new Splitting("hello friend");
            string[] words = { };
            for (int i = 0; i < splitting.Sentence.Length; i++)
            {
                words = splitting.ReturnSplittedWordsInArray(splitting.Sentence);
                Console.WriteLine(words[i]);
            }
        }
    }
    class Splitting
    {
        public string Sentence { get; set; }

        public Splitting(string sentence)
        {
            this.Sentence = sentence;

        }
        public string[] ReturnSplittedWordsInArray(string sentence)
        { string[] words = sentence.Split(' ');
           
            return words;
        }
    }
}