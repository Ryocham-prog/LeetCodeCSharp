using System;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var solution = new Solution();
            var x = 121;
            solution.IsPalindrome(x);
        }
    }

    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;

            var strNum = x.ToString();
            var len = strNum.Length;
            if (len == 1) return true;

            var reverseNum = string.Empty;
            for (int i = len; i > 0; i--)
            {
                reverseNum += strNum.Substring(i - 1, 1);
            }

            if (strNum == reverseNum)
            {
                return true;
            }

            return false;
        }
    }
}
