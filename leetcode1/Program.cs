using System;

namespace leetcode1
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int k = 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[k] == target)
                    {
                        return new int[] { i, k };
                    }
                }
            }
            return new int[0];
        }
    }
}
