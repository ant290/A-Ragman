using A_Ragman.Helpers;
using System;
using System.Linq;

namespace A_Ragman
{
    class Program
    {
        static void Main(string[] args)
        {
            //set up list of words
            //TODO Dependancy injection on listGenerator
            var listGenerator = new WordListGenerator(); //this could be any class which implements IWordListGenerator
            var wordList = listGenerator.GetWords();

            //set up anagram checker
            var checker = new AnagramComparer(); //this could be any class which implements IWordComparer

            //loop to show word generation
            Console.WriteLine("Starting list of words:");
            foreach(var i in wordList)
            {
                Console.WriteLine($"Wordpair: {i.word1}, {i.word2}");
            }

            //filter to just anagrams
            Console.WriteLine("Selecting pairs which are anagrams");
            //realised i could use a linq query here instead of for each loop
            var anagrams = wordList.Where(i => checker.CompareWords(i.word1, i.word2));

            //used for each to make it clearer what the output would look like
            foreach (var i in anagrams)
            {
                Console.WriteLine($"Anagram: {i.word1}, {i.word2}");
            }

            //wait for entry for exit
            Console.ReadLine();
        }
    }
}
