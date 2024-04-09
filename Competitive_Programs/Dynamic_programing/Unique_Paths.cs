using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Dynamic_programing
{
    internal class Unique_Paths
    {
        public int uniquePaths(int m, int n)
        {
            int[,] dp = new int[m,n];

            for (int i = 1; i < m; ++i)
                for (int j = 1; j < n; ++j)
                    dp[i,j] = dp[i - 1,j] + dp[i,j - 1];

            return dp[m - 1,n - 1];
        }
    }
}
