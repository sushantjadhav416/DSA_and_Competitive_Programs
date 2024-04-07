using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Searching_algos
{
    internal class Median_of_Two_Sorted_Arrays
    {
        public double findMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] arr = new int[nums1.Length + nums2.Length];

            int i = 0, j = 0, k = 0;

            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    arr[k++] = nums1[i++];
                }
                else
                {
                    arr[k++] = nums2[j++];
                }
            }

            while (i < nums1.Length)
            {
                arr[k++] = nums1[i++];
            }

            while (j < nums2.Length)
            {
                arr[k++] = nums2[j++];
            }

            if (arr.Length % 2 == 0)
            {
                return (double)(arr[arr.Length / 2] + arr[(arr.Length / 2) - 1]) / 2;
            }
            else
            {
                return (double)arr[arr.Length / 2];
            }

        }
    }
}
