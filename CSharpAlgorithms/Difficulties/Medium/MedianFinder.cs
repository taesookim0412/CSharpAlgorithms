using System;
using System.Collections.Generic;

namespace CSharpAlgorithms.Difficulties.Medium
{
    // TLE
    public class MedianFinder
    {

        List<int> nums;

        public MedianFinder()
        {
            this.nums = new List<int>();
        }

        public void AddNum(int num)
        {
            this.nums.Add(num);

        }

        public double FindMedian()
        {
            this.nums.Sort();
            int sz = this.nums.Count;
            double res;
            //if even
            if (sz % 2 == 0)
            {
                double upperNum = this.nums[(int) Math.Ceiling((decimal) (sz - 1) / 2)];
                double lowerNum = this.nums[(int) Math.Floor((decimal) (sz - 1) / 2)];
                res = (upperNum + lowerNum) / 2;
            }
            else
            {
                res = this.nums[sz / 2];
            }

            return res;
        }
    }
}