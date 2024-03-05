using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Searching_algos
{
    internal class Maximum_Index
    {
        static int max(int x, int y)
        {
            return x > y ? x : y;
        }

        static int min(int x, int y)
        {
            return x > y ? y : x;
        }

        static int maxIndexDiff(int[] a, int n)
        {

            // Your code here
            int max_index = -1;

            // for(int i=0;i<n;i++)
            // {
            //     for(int j=1;j<n;j++)
            //     {
            //       if((a[i] <= a[j]) && i <= j) 
            //       {
            //           if((j-i)>max_index)
            //               max_index = j-i;
            //       }
            //     }
            // }

            int[] Lmin = new int[n];
            int[] Rmax = new int[n];

            Lmin[0] = a[0];
            for(int p = 1; p < n; ++p)
            {
                Lmin[p] = min(a[p], Lmin[p - 1]);
            }

            Rmax[n - 1] = a[n - 1];
            for (int q = n - 2; q >= 0; --q)
            {
                Rmax[q] = max(a[q], Rmax[q + 1]);
            }

            int i = 0, j = 0;
            while (i < n && j < n)
            {
                if (Lmin[i] <= Rmax[j])
                {
                    max_index = max(max_index, j - i);
                    j = j + 1;
                }
                else
                {
                    i = i + 1;
                }

            }

            return max_index;

        }
    }
}
