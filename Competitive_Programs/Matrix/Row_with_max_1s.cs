using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Matrix
{
    internal class Row_with_max_1s
    {
        int rowWithMax1s(int[,] arr, int n, int m)
        {
            // code here
            int count, MaxCount = int.MinValue, index = 0;
            bool flag = true;

            for (int i = 0; i < n; i++)
            {
                count = 0;
                for (int j = 0; j < m; j++)
                {
                    if (arr[i,j] == 1)
                    {
                        count++;
                        flag = false;
                    }
                }

                if (MaxCount < count)
                {
                    MaxCount = count;
                    index = i;
                }
            }

            if (flag)
                return -1;

            return index;
        }
    }
}
