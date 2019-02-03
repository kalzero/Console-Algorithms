using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Algorithms.Algorithms
{
    public class Anagram
    {
        public bool AreWordsAnagram(string word1, string word2)
        {          
            char[] newWord1 = word1.ToLower().ToCharArray();
            char[] newWord2 = word2.ToLower().ToCharArray();

            Array.Sort(newWord1);
            Array.Sort(newWord2);

            var sortedWord1 = new string(newWord1);
            var sortedWord2 = new string(newWord2);

            if (sortedWord1 == sortedWord2)
                return true;

            return false;
        }
    }
}
