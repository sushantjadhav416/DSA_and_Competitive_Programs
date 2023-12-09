using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Arrays
{
    internal class array_find_num_sum
    {
        public static void sum_find_num_n2(int[] arr, int n) 
        { 
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if ((arr[i] + arr[j]) == n)
                    {

                        Console.WriteLine("pairs {0} and {1}", arr[i], arr[j]);  
                    }
                } 
            }
        
        }

        public static void find_sum_nlogn(int[] arr,int n)
        {
           int  low = 0;
           int high = arr.Length - 1;

           while(low < high)
            {
                if ((arr[low] + arr[high]) == n)
                {
                    Console.Write("(" + arr[low] +" , " + arr[high] + ") " ); 
                }

                if ((arr[low] + arr[high]) > n)
                {
                    high--;
                }
                else
                {
                    low++;
                }

            }

        }
       

        public static void as_Main(string[] args)
        {
            int[] a = { 34, 23, 45, 65, 67, 87, 98 };
            //sum_find_num_n2(a, 133);
            find_sum_nlogn(a, 132);
        }


    }

}
