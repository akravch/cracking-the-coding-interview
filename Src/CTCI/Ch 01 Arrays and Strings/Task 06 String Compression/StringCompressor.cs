using System.Text;

namespace CTCI.Ch_01_Arrays_and_Strings.Task_06_String_Compression
{
    public class StringCompressor
    {
        public string Compress(string str)
        {
            var length = str.Length;

            if (length < 3)
            {
                return str;
            }

            var previousSymbol = '\0';
            var previousSymbolCount = 0;
            var builder = new StringBuilder();

            foreach (var symbol in str)
            {
                if (previousSymbol != symbol)
                {
                    if (previousSymbolCount > 0)
                    {
                        builder.Append(previousSymbolCount);
                    }

                    previousSymbol = symbol;
                    previousSymbolCount = 1;

                    builder.Append(symbol);
                }
                else
                {
                    previousSymbolCount++;
                }

                if (builder.Length >= length)
                {
                    break;
                }
            }

            builder.Append(previousSymbolCount);

            return builder.Length >= length
                ? str
                : builder.ToString();
        }
    }
}