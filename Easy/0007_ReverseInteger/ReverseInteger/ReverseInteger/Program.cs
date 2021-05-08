using System;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("反転させたい数値を入力してください。");
                var input = Console.ReadLine();
                if(input == "")
                {
                    Console.WriteLine("値を入力してください。");
                    Console.ReadKey();
                    return;
                }
                var inNum = int.Parse(input);

                var solution = new Solution();
                var rtn = solution.Reverse(inNum);

                Console.WriteLine($"\n反転後の値: {rtn}");
                Console.ReadKey();

            }
            catch(OverflowException ex)
            {
                Console.WriteLine("\n入力値の最大値は2147483647、最小値は-2147483648です。");
                Console.ReadKey();
            }
        }
    }

    public class Solution
    {
        public int Reverse(int x)
        {
            var res = 0;
            if (x == 0) return 0;

            while (x != 0)
            {
                res *= 10;
                res += x % 10;
                x /= 10;

                if (x != 0 && res < 0 && (res < -214748364 || (res == -2147483640 && x < -8)))
                {
                    return 0;
                }

                if (x != 0 && res > 0 && (res > 214748364 || (res == 2147483640 && x > 7)))
                {
                    return 0;
                }
            }
            return res;
        }
    }
}
