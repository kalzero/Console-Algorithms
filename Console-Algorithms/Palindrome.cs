using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Algorithms
{
    public class Palindrome
    {
        public void ReverseString(string word, out string stringResult)
        {  
            string reversedWord = string.Empty;
            for (int i = word.Length - 1; i >= 0; i--)
            {               
                reversedWord += word[i];                
            }

            ValidatePalindrome(word, reversedWord, out stringResult);
        }

        private void ValidatePalindrome(string origWord, string reversedWord, out string stringResult)
        {
            if (origWord.ToLower() == reversedWord.ToLower())
            {
                stringResult = $"Original word {origWord} and reversed word {reversedWord} resulted in true";
                return;
            }

            stringResult = $"Original word {origWord} and reversed word {reversedWord} resulted in false";
        }
    }
}
