using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Arrays
{
    internal class Count_Pairs_in_an_Array
    {
        static int Merge(int[] arr, int[] temp, int left, int mid, int right)
        {

            int in_count = 0;

            int i = left;
            int j = mid;
            int k = left;

            while ((i <= mid - 1) && (j <= right))
            {
                if (arr[i] <= arr[j])
                {
                    temp[k++] = arr[i++];
                }
                else
                {
                    temp[k++] = arr[j++];

                    in_count += mid - i;

                }

            }

            while (i <= mid - 1)
                temp[k++] = arr[i++];


            while (j <= right)
                temp[k++] = arr[j++];


            for (i = left; i <= right; i++)
                arr[i] = temp[i];

            return in_count;

        }

        static int MergeSort(int[] arr, int[] temp, int left, int right)
        {

            int mid, in_count = 0;

            if (right > left)
            {
                mid = (left + right) / 2;

                in_count = MergeSort(arr, temp, left, mid);
                in_count += MergeSort(arr, temp, mid + 1, right);

                in_count += Merge(arr, temp, left, mid + 1, right);
            }

            return in_count;
        }

        static int countPairs(int[] arr, int n)
        {
            // Your code goes here

            //  int count=0;
            //  for(int i=0;i<n;i++)
            //  {
            //      for(int j=0;j<n;j++)
            //      {

            //          if((i*arr[i])>(j*arr[j]) && i<j && j<n)
            //          {
            //              count++;
            //          }

            //      }
            //  }

            int[] temp = new int[n];

            for (int i = 0; i < n; i++)
                arr[i] = i * arr[i];

            return MergeSort(arr, temp, 0, n - 1);

        }
    }
}
