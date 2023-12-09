using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Sorting_algo
{
    internal class insertion_sort
    {
        public static void ins_sort(int[] arr)
        {
            int i ,j, temp ;

            for (i = 1; i < arr.Length; i++) {
                temp = arr[i];
                j = i - 1;

                while (j >= 0 && temp <= arr[j])
                {
                    arr[j+1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = temp;
            }
        }
        public static void in_Main(string[] args) 
        {
            int[] arr = { 32, 31, 34, 45, 65, 78, 98, 23 };

            ins_sort(arr);

            for(int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i]+" ");
            }

        }

    }
}
