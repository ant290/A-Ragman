using A_Ragman.Interfaces;
using System;
using System.Linq;

namespace A_Ragman
{
    public class AnagramComparer : IWordComparer
    {
        /// <summary>
        /// compares two strings to check if they are anagrams of each other
        /// </summary>
        /// <param name="word1"></param>
        /// <param name="word2"></param>
        /// <returns>true/false</returns>
        public bool CompareWords(string word1, string word2)
        {
            //bit of defensive coding, also makes sure it passes the test for the interface
            if (word1 == null || word2 == null)
            {
                throw new ArgumentNullException($"invalid parameters: {word1 ?? "null"}, {word2 ?? "null"} for anagram comparison.");
            }

            //linq from internet... it works
            //return !(((word1 + word2).Any(c => word1.Count(x => x == c) != word2.Count(x => x == c))));

            //easier to understand method (for me)
            //sort both words by letter
            var _word1 = string.Concat(word1.OrderBy(i => i));
            var _word2 = string.Concat(word2.OrderBy(i => i));

            //check if both are the same
            return (_word1.ToLower() == _word2.ToLower());
        }
    }
}
