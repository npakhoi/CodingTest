using System.Collections.Generic;

namespace ClassTechTest
{
    public class StringTools
    {
        #region String Tool Problems

        public string FindFirstDuplicatedCharacter(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            var charDict = new Dictionary<char, char>();

            foreach (var inputChar in input)
            {
                if (char.IsLetterOrDigit(inputChar))
                {
                    // Return its storaged value or add a new key-value pair.
                    if (charDict.ContainsKey(char.ToUpper(inputChar)))
                    {
                        return charDict[char.ToUpper(inputChar)].ToString();
                    }
                    charDict[char.ToUpper(inputChar)] = inputChar;
                }
            }

            return null;
        }

        #endregion

        #region Palindrome Problems

        public bool IsPalindrome(string input)
        {
            return true;
        }
        
        public string FindLargestPalindrome(string input)
        {
            return null;
        }

        #endregion
    }
}
