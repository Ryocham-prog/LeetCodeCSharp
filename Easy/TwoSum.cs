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
