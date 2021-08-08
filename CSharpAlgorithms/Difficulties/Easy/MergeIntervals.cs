using System;
using System.Collections.Generic;

namespace CSharpAlgorithms.Difficulties.Easy
{
    public class MergeIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length < 2) return intervals;
            Array.Sort(intervals, (a, b) => a[0] - b[0]);
            var res = new List<int[]> {intervals[0]};
            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] <= res[^1][1] && intervals[i][1] >= res[^1][1])
                {
                    res[^1][1] = intervals[i][1];
                }
                else if (intervals[i][1] > res[^1][1])
                {
                    res.Add(intervals[i]);
                }
            }
            return res.ToArray();
        }
    }
}