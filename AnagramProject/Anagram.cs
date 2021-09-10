using System;

namespace AnagramProject
{
    public class Anagram
    {
        public string Reverse(string sourceString)
        {
            if(sourceString == null) return "";

            string anagram = "";

            string[] sourseWords = sourceString.Split(" ");

            for (int i = 0; i < sourseWords.Length; i++)
            {
                anagram += ReverseWord(sourseWords[i]);

                if (i < sourseWords.Length - 1)
                {
                    anagram += " ";
                }
            }

            return anagram;
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
