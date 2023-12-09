using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Arrays
{
    internal class Merge_sorted_array
    {
        public static void merge_so_ar(int[] a, int[] b)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while(i<a.Length)
            {
                a[k++] = b[i++];
            }

            while(j<b.Length)
            {
                a[k++] = b[j++];
            }

            Array.Sort(a);
        }

        public static void soa_Main(string[] args)
        {
            int[] arr1 = { 1, 7, 9, 3, 4, 0, 0, 0 };
            int[] arr2 = { 2, 5, 6 };

            merge_so_ar(arr1, arr2);
        }
    }
}
