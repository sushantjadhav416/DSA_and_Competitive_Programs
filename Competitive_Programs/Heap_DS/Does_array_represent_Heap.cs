using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Heap_DS
{
    internal class Does_array_represent_Heap
    {
        public bool countSub(long[] arr, long n)
        {
            // Your code goes here
            for (int i = 0; i <= (n - 2) / 2; i++)
            {
                if (arr[2 * i + 1] > arr[i])
                {
                    return false;
                }

                if (2 * i + 2 < n && arr[2 * i + 2] > arr[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
