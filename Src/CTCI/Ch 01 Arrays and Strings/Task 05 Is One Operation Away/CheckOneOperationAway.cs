namespace CTCI.Ch_01_Arrays_and_Strings.Task_05_Is_One_Operation_Away
{
    public class CheckOneOperationAway
    {
        public bool IsOneAway(string str1, string str2)
        {
            var lengthDiff = str1.Length - str2.Length;

            if (lengthDiff > 1 || lengthDiff < -1)
            {
                return false;
            }


            string longerStr;
            string shorterStr;

            if (lengthDiff > 0)
            {
                longerStr = str1;
                shorterStr = str2;
            }
            else
            {
                longerStr = str2;
                shorterStr = str1;
            }

            var oneAway = false;

            for (int shorterIndex = 0, longerIndex = 0; shorterIndex < shorterStr.Length; shorterIndex++, longerIndex++)
            {
                var char1 = shorterStr[shorterIndex];
                var char2 = longerStr[longerIndex];

                if (char1 != char2)
                {
                    if (oneAway)
                    {
                        return false;
                    }

                    oneAway = true;

                    if (lengthDiff != 0)
                    {
                        longerIndex++;
                    }
                }
            }

            return true;
        }
    }
}