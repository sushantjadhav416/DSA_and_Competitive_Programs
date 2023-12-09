using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Arrays
{
    internal class merge_arrays
    {
        public merge_arrays(long[] arr1, long[] arr2,int n,int m) 
        {
            int left = arr1.Length-1;
            int right = 0;

            while (left>0 && right < m)
            {
                if (arr1[left] > arr2[right])
                {
                    long temp = arr1[left];
                    arr1[left] = arr2[right];
                    arr2[right] = temp;
                    left--;
                    right++;
                }
                else
                {
                    break;
                }

            }
            Array.Sort(arr1);
            Array.Sort(arr2);    
        }

        public static void merging(long[] aar1,long[] arr2)
        {
            int n = aar1.Length+arr2.Length;
            long[] out_arr = new long[n];
            int j = 0;
            for(int i = 0; i < aar1.Length; i++)
            {
                out_arr[j] = aar1[i];
                j++;
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                out_arr[j] = aar1[i];
                j++;
            }
            for (int i = 0; i < out_arr.Length; i++)
            {
                Console.WriteLine(out_arr[i]);
            }

        }
        public static void ma_Main(string[] args)
        {


        }
    }
}
