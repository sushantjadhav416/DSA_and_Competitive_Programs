using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Searching_algos
{
    internal class Kth_Missing_Positive_Number
    {

        public int findKthPositive(int[] arr, int k)
        {

            int l = 0;
            int r = arr.Length;

            while (l < r)
            {
                int m = (l + r) / 2;

                if (arr[m] - m - 1 >= k)
                {
                    r = m;
                }
                else
                {
                    l = m + 1;
                }
            }

            return l + k;

        }


    }
}
