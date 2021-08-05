using System;
using System.Collections.Generic;

namespace CSharpAlgorithms
{
    public class twoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {

            Dictionary<int, int> hashMap = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                int difference = target - num;
                if (hashMap.ContainsKey(difference))
                {
                    return new int[] {hashMap[difference], i};
                }
                hashMap.Add(num, i);
            }
            return new int[2];
        }
    }
}