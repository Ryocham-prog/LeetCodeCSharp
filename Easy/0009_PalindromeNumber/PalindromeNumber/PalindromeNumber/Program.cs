using System;
using System.Text;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var palNum = new Program();
            var x = 121;
            palNum.IsPalindrome(x);
            palNum.IsPalindrome2(x);
        }

        // Runtime: 72 ms
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;

            var strNum = x.ToString();
            var len = strNum.Length;
            if (len == 1) return true;

            var reverseNum = new StringBuilder();
            for (int i = len; i > 0; i--)
            {
                reverseNum.Append(strNum.Substring(i - 1, 1));
            }
            return strNum == reverseNum.ToString();
        }

        // Runtime: 60 ms
        public bool IsPalindrome2(int x)
        {
            if (x < 0) return false;

            var strNum = x.ToString();
            var len = strNum.Length;
            if (len == 1) return true;

            var compareCount = len / 2;

            for (int i = 0; i < compareCount; i++)
            {
                if (strNum.Substring(i, 1) != strNum.Substring(len - 1 - i, 1)) return false;
            }
            return true;
        }

    }
}
