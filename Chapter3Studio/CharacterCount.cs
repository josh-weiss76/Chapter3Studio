using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter3Studio
{
    public class CharacterCount
    {
        public static Dictionary<char, int> CharacterTypeCount(char[] array)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();
            foreach (char letter in array)
            {
                if (characterCount.ContainsKey(letter))
                    characterCount[letter]++;
                else
                    characterCount.Add(letter, 1);
            }
            foreach (KeyValuePair<char, int> character in characterCount)
            {
                Console.WriteLine(character.Key + ":" + character.Value);
            }

            return characterCount;
        }
    }
}
