using System.Collections.Generic;

namespace ClassTechTest
{
    public class StringTools
    {
        #region String Tool Problems

        /// <summary>
        /// Find the first duplicated character in the input.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>The first duplicated character.</returns>
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

        /// <summary>
        /// Check whether the input is a palindrome.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>Return true if the input is a palindrome; otherwise, return false.</returns>
        public bool IsPalindrome(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }
            if (input.Length == 1)
            {
                return true;
            }

            int leftIdx;
            int rightIdx;

            // Get the index values of the characters to the left and right of the middle of the string.
            if (input.Length % 2 != 0)
            {
                leftIdx = (input.Length / 2) - 1;
                rightIdx = (input.Length / 2) + 1;
            }
            else
            {
                leftIdx = (input.Length / 2) - 1;
                rightIdx = input.Length / 2;
            }

            while (leftIdx >= 0)
            {
                if (char.ToLower(input[leftIdx]) != char.ToLower(input[rightIdx]))
                {
                    return false;
                }
                leftIdx--;
                rightIdx++;
            }

            return true;
        }

        /// <summary>
        /// Find the longest palindrome in the input.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>The longest palindrome.</returns>
        public string FindLargestPalindrome(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return null;
            }
            if (input.Length == 1)
            {
                return input;
            }

            var longestStr = "";
            var strCollection = new HashSet<string>();

            // Get all possible text segments from the given input string.
            for (int i = 0; i < input.Length; i++)
            {
                for (int y = i; y < input.Length; y++)
                {
                    strCollection.Add(input.Substring(i, y - i + 1));
                }
            }

            foreach (string str in strCollection)
            {
                var isPalindrome = IsPalindrome(str);
                if (isPalindrome && str.Length > longestStr.Length)
                {
                    longestStr = str;
                }
            }

            if (string.IsNullOrEmpty(longestStr) || longestStr.Length <= 1)
            {
                return null;
            }
            else
            {
                return longestStr;
            }
        }

        #endregion
    }
}
