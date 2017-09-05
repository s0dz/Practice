using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace Practice
{
    // apple -> eppla
    // friend -> freind
    public class WordUtilities
    {
        public WordUtilities()
        {
        }

        private readonly List<char> _vowels = new List<char>
        {
            'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U'
        };

        public string ReverseVowels(string word)
        {
            var wordAsCharArray = word.ToCharArray();
            var vowels = new ArrayList();

            foreach (var c in wordAsCharArray)
            {
                if (IsVowel(c)){
                    vowels.Add(c);
                }
            }

            vowels.Reverse();

            for (var i = 0; i < wordAsCharArray.Length; i++)
            {
                if (IsVowel(wordAsCharArray[i]))
                {
                    wordAsCharArray[i] = (char) vowels[0];
                    vowels.RemoveAt(0);
                }
            }

            return new string(wordAsCharArray);
        }

        public bool IsVowel(char c)
        {
            return _vowels.Contains(c);
        }
    }
}
