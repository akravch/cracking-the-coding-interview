using System;

namespace CTCI.Ch_01_Arrays_and_Strings.Task_09_Cyclic_Shift
{
    public class CyclicShift
    {
        public bool IsCyclicShift(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }

            var doubleStr1 = str1 + str1;
            var isSubstring = doubleStr1.IndexOf(str2, StringComparison.Ordinal) != -1;

            return isSubstring;
        }
    }
}