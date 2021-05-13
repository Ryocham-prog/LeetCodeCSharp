using System;
using System.Linq;
using System.Text;

namespace _0014_LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var loncompre = new Program();
            var strs = new string[3] {"flower", "flow", "flight"};
            loncompre.LongestCommonPrefix(strs);
        }

        // Runtime: 120ms
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1) return strs[0];

            var minLen = 200;
            var minStr = string.Empty;
            foreach (string str in strs)
            {
                if (str.Length < minLen)
                {
                    minLen = str.Length;
                    minStr = str;
                }
            }

            var commonPrefix = string.Empty;
            var checkStr = string.Empty;
            var targetPrefix = new StringBuilder();
            foreach (var letter in minStr)
            {
                checkStr = targetPrefix.Append(letter).ToString();
                if (!strs.All(x => x.StartsWith(checkStr))) break;

                commonPrefix = checkStr;
            }
            return commonPrefix;
        }
    }
}
