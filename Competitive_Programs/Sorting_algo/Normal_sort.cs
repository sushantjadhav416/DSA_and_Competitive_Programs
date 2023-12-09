using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Sorting_algo
{

    //Selection Sort
    internal class Normal_sort
    {
        public static void Sorting(int[] arr)
        {
            
           
            for( int i = 0; i < arr.Length; i++ )
            {
                for ( int j = 0; j < arr.Length; j++ )
                {
                    if (arr[i] > arr[j])
                    {
                        arr[i] = arr[i] ^ arr[j];
                        arr[j] = arr[i] ^ arr[j];
                        arr[i] = arr[i] ^ arr[j];
                    }
                }
            }

        }
        //Time complexity O(arr.Length*2)
        //Space complexity 
        public static void so_Main(string[] args)
        {
            int[] arr = { 4, 5, 3, 44, 55, 21, 33, 44, 6, 76 };

            Sorting(arr);

            for(int i=0; i<arr.Length; i++) {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
