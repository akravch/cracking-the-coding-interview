using System.Collections.Generic;

namespace CTCI.Ch_01_Arrays_and_Strings.Task_04_Palindrome_Permutation
{
    public class PalindromePermutation
    {
        public bool IsPalindromePermutation1(string str)
        {
            var dictionary = new Dictionary<char, int>();

            foreach (var c in str)
            {
                if (c != ' ')
                {
                    var symbol = char.ToLower(c);

                    dictionary.TryGetValue(symbol, out var count);
                    dictionary[symbol] = count + 1;
                }
            }

            var foundOddCount = false;

            foreach (var pair in dictionary)
            {
                if (pair.Value % 2 != 0)
                {
                    if (foundOddCount)
                    {
                        return false;
                    }

                    foundOddCount = true;
                }
            }

            return true;
        }

        private static int GetCharNumber(char c)
        {
            if (char.IsUpper(c))
            {
                c = char.ToLower(c);
            }

            return c - 'a';
        }

        private static bool IsPowerOfTwo(int value)
        {
            // Example for 4
            // 4         : 100
            // 4 - 1 = 3 : 011
            // 100 & 011 = 0
            return (value & (value - 1)) == 0;
        }

        public bool IsPalindromePermutation2(string str)
        {
            var bitmap = 0;

            foreach (var symbol in str)
            {
                if (symbol != ' ')
                {
                    var symbolNumber = GetCharNumber(symbol);
                    var symbolMask = 1 << symbolNumber;

                    bitmap ^= symbolMask;
                }
            }

            return bitmap == 0 || IsPowerOfTwo(bitmap);
        }
    }
}