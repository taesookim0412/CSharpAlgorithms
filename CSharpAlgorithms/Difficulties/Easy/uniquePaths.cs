using System;

namespace CSharpAlgorithms.Difficulties.Easy
{
    public class uniquePaths
    {
        public int UniquePaths(int m, int n)
        {
            //m rows, n cols
            int[,] dp = new int[m + 1, n + 1];
            for (int i = 1; i < m + 1; i++)
            {
                dp[i, 1] = 1;
            }

            for (int j = 1; j < n + 1; j++)
            {
                dp[1, j] = 1;
            }

            // Easy.printMatrix(dp);
            for (int i = 2; i < dp.GetLength(0); i++)
            {
                for (int j = 2; j < dp.GetLength(1); j++)
                {
                    // Easy.printMatrix(dp);
                    dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                }
            }

            // Easy.printMatrix(dp);
            return dp[dp.GetLength(0) - 1, dp.GetLength(1) - 1];

        }
    }
}