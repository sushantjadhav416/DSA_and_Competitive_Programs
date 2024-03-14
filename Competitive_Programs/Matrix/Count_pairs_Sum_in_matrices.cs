using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Matrix
{
    internal class Count_pairs_Sum_in_matrices
    {
        int countPairs(int[,] mat1, int[,] mat2, int n, int x)
        {
            // code here

            HashSet<int> HA = new HashSet<int>();

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    HA.Add(mat2[i, j]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (HA.Contains(x - mat1[i,j]))
                        count++;
                }
            }

            return count;

        }
    }
}
