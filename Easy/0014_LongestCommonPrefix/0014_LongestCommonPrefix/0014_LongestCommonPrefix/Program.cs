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
            //var strs = new string[1] { "a" };
            //var strs = new string[2] { "ab", "a" };
            //var strs = new string[2] { "aa", "a" };
            var strs = new string[3] {"flower", "flow", "flight"};
            //var strs = new string[3] { "dog", "racecar", "car" };
            loncompre.LongestCommonPrefix2(strs);
        }

        // Runtime: 120ms
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1) return strs[0];

            var minLen = 200;
            var searchStr = string.Empty;
            foreach (string str in strs)
            {
                if (str.Length < minLen)
                {
                    minLen = str.Length;
                    searchStr = str;
                }
            }
            var checkStr = searchStr.Substring(0, minLen - 0);

            var commonPrefix = string.Empty;
            var searchword = string.Empty;
            var searchPrefix = new StringBuilder();
            foreach (var letter in searchStr)
            {
                searchword = searchPrefix.Append(letter).ToString();
                if (!strs.All(x => x.StartsWith(searchword))) break;

                commonPrefix = searchword;
            }
            return commonPrefix;
        }

        // Runtime: 96ms
        public string LongestCommonPrefix2(string[] strs)
        {
            var strCount = strs.Length;
            if (strCount == 1) return strs[0];

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

            if (minLen == 0) return string.Empty;

            var commonPrefix = new StringBuilder();
            var idx = 0;
            foreach (var letter in minStr)
            {
                var checkFlag = true;
                for (int i = 0; i < strCount; i++)
                {
                    if (!(strs[i].Substring(idx, 1) == letter.ToString()))
                    {
                        checkFlag = false;
                        break;
                    }
                }
                if (!checkFlag) break;
                commonPrefix.Append(letter);
                idx++;
            }
            return commonPrefix.ToString();
        }
    }
}
