using System.Collections.Generic;

namespace CTCI.Ch_01_Arrays_and_Strings.Task_01_Unique_Symbols
{
    public class UniqueSymbols
    {
        public bool IsUnique(string str)
        {
            var hashSet = new HashSet<char>();

            foreach (var symbol in str)
            {
                if (!hashSet.Add(symbol))
                {
                    return false;
                }
            }

            return true;
        }
    }
}