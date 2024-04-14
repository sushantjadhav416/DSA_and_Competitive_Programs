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

        public static void merge_sorted(int[] a, int[] b)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while(i<a.Length && j<b.Length)
            {
                if (a[i] < b[j])
                {
                    a[k++] = a[i++];
                }
                else
                {
                    a[k++] = b[j++];
                }
            }

            while (i<a.Length)
            {
                a[k++] = b[i++];
            }

            while(j<b.Length)
            {
                a[k++] = b[j++];
            }

        }

        public static void s_Main(string[] args)
        {
            int[] arr1 = { 1, 7, 9, 3, 4, 0, 0, 0 };
            int[] arr2 = { 2, 5, 6 };

            merge_sorted(arr1, arr2);
        }
    }
}
