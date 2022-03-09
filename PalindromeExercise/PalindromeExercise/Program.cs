using System;
using System.Collections.Generic;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            char[] flip = word.ToCharArray();
            Array.Reverse(flip);
            string check = new string(flip);

            return check == word;
        }
    }
}