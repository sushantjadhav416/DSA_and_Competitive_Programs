using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Searching_algos
{
    internal class Transition_point
    {
        int transitionPoint(int[] arr, int n)
        {
            // code here

            int l = 0;
            int r = n - 1;

            while (l <= r)
            {
                int mid = (l + r) / 2;

                if (arr[mid] == 0)
                {
                    l = mid + 1;
                }
                else if (arr[mid] == 1)
                {
                    if (mid == 0 || (arr[mid - 1] == 0))
                    {
                        return mid;
                    }

                    r = mid - 1;
                }

            }

            return -1;
        }
    }
}
