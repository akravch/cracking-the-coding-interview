namespace CTCI.Ch_01_Arrays_and_Strings.Task_03_Urlify_Spaces
{
    public class UrlifySpaces
    {
        public char[] Urlify1(char[] str, int textLength)
        {
            var result = new char[str.Length];
            var resultIndex = 0;

            for (var i = 0; i < textLength; i++)
            {
                var symbol = str[i];

                if (symbol != ' ')
                {
                    result[resultIndex++] = symbol;
                }
                else
                {
                    result[resultIndex++] = '%';
                    result[resultIndex++] = '2';
                    result[resultIndex++] = '0';
                }
            }

            return result;
        }

        public char[] Urlify2(char[] str, int textLength)
        {
            var spaces = 0;

            foreach (var c in str)
            {
                if (c == ' ')
                {
                    spaces++;
                }
            }

            var index = textLength - 1;

            while (spaces > 0)
            {
                var symbol = str[index];
                var newIndex = index + spaces * 2;

                if (symbol != ' ')
                {
                    str[newIndex] = symbol;
                    str[index] = ' ';
                }
                else
                {
                    str[newIndex] = '0';
                    str[newIndex - 1] = '2';
                    str[newIndex - 2] = '%';

                    spaces--;
                }

                index--;
            }

            return str;
        }
    }
}