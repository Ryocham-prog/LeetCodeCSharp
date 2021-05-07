using System;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxCount = 1000;
            try
            {
                Console.WriteLine("判定したい合計値を入力してください。");
                var targetValue = int.Parse(Console.ReadLine());

                var inArray = new int[maxCount];
                Console.WriteLine("\n判定したい値を入力してください。");
                Console.WriteLine("(入力を終了する場合は、Enterキーを押下してください。)\n");

                for (int i = 0; i < maxCount; i++)
                {
                    Console.WriteLine("No.{0} : ", i + 1);
                    var inData = Console.ReadLine();

                    if (inData == string.Empty && i < 2)
                    {
                        Console.WriteLine("必ず2つ以上の値を入力してください。");
                        Console.ReadKey();
                        return;
                    }
                    else if (inData == string.Empty)
                    {
                        break;
                    }

                    inArray[i] = int.Parse(inData);
                }

                var solution = new Solution();
                var rtn = solution.TwoSum(inArray, targetValue);

                if(rtn == null)
                {
                    Console.WriteLine("入力した合計値と和が一致する組み合わせは、存在しません。");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($"合計値: {targetValue}");
                    Console.WriteLine($"組み合わせ: No.{rtn[0]+1}, No.{rtn[1]+1}");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("入力値が不正です。");
                Console.ReadKey();
            }
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                var subNum = target - nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == subNum)
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }
            return null;
        }
    }
}
