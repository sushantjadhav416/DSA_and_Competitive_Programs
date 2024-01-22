using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//VVVIMP

namespace Competitive_Programs_and_DSA_Qns.Searching_algos
{
    internal class Search_in_infinite_number_arr
    {
        public static int search(int[] arr,int target)
        {
            
            int start = 0;
            int end = 1;

            while(target > arr[end])
            {
                int temp = end + 1;

                end = end + (end - start) * 2;

                start = temp;
            }

            return binary_search(arr,start,end,target);

        }
        public static int binary_search(int[] arr,int start,int end, int target)
        {
            int l = start, r = end;

            while (l <= r)
            {
                int m = l + (r - l) / 2;

                if (arr[m] == target)
                    return m;

                if (arr[m] < target)
                    l = m + 1;
                else
                    r = m - 1;

            }

            return -1;

        }

        
    }
}
