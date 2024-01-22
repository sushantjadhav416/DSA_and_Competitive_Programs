using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Sorting_algo
{
    internal class Merge_sort
    {
        void merge(int[] arr, int[] first, int[] second)
        {
            // Your code here
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < first.Length && j < second.Length)
            {
                if (first[i] < second[j])
                {
                    arr[k] = first[i];
                    i++;
                }
                else
                {
                    arr[k] = second[j];
                    j++;
                }
                k++;
            }

            while (i < first.Length)
            {
                arr[k] = first[i];
                i++;
                k++;
            }
            while (j < second.Length)
            {
                arr[k] = second[j];
                j++;
                k++;
            }

        }
        int[] merging(int[] arr)
        {
            if (arr.Length == 1)
                return arr;

            int mid = arr.Length / 2;

            int[] left = new int[mid];
            int[] right = new int[mid];

            //merging(Array.Copy(left,arr,mid));

           // merging(Array.Copy(arr,right,arr.Length));

            merge(arr, left, right);
            return arr;
        }
        void mergeSort(int[] arr, int l, int r)
        {
            //code here
            merging(arr);
        }
        public static void mt_Main(string[] args)
        {

        }
    }
}
