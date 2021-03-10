using System;
using System.Collections.Generic;

namespace CTCI.Ch_01_Arrays_and_Strings.Task_02_Check_Permutations
{
    public class CheckPermutations
    {
        public bool IsPermuted1(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }

            var dictionary = new Dictionary<char, int>();

            foreach (var c in str1)
            {
                dictionary.TryGetValue(c, out var count);
                dictionary[c] = count + 1;
            }

            foreach (var c in str2)
            {
                dictionary.TryGetValue(c, out var count);
                dictionary[c] = count - 1;
            }

            foreach (var pair in dictionary)
            {
                if (pair.Value != 0)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsPermuted2(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }

            var array1 = str1.ToCharArray();
            var array2 = str2.ToCharArray();

            Array.Sort(array1);
            Array.Sort(array2);

            for (var i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}