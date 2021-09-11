using System;

namespace AnagramProject
{
    public class Anagram
    {
        public string Reverse(string sourceString)
        {
            if (sourceString == null) 
            {
                return ""; 
            }

            string[] sourseWords = sourceString.Split(" ");
            string[] reverseWords = new string[sourseWords.Length];

            for (int i = 0; i < sourseWords.Length; i++)
            {
                reverseWords[i] = ReverseWord(sourseWords[i]);
            }

            return String.Join(" ", reverseWords);
        }

        private string ReverseWord(string word)
        {
            char[] chars = word.ToCharArray();
            int wordLength = chars.Length;
            char[] reverseChars = new char[wordLength];
            int charOffset = 0;

            for (int i = 0; i < wordLength; i++)
            {
                if (!Char.IsLetter(chars[i])) reverseChars[i] = chars[i];
            }

            for (int i = 0; i < wordLength; i++)
            {
                if (Char.IsLetter(chars[i]))
                {
                    charOffset++;

                    for (int j = wordLength - charOffset; j >= 0; j--)
                    {
                        if (reverseChars[j] == '\0')
                        {
                            reverseChars[j] = chars[i];
                            break;
                        }
                    }
                }
            }

            return new string(reverseChars);
        }
    }
}
