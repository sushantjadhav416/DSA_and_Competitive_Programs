using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Searching_algos
{
    internal class Celling_number
    {

        public static int Cel_num(int[] arr,int target)
        {
            int start = 0;
            int end = arr.Length-1;
          

            while (start <= end)
            {
                int mid = start+(end-start) / 2;

                if (arr[mid] >= target)
                      return arr[mid];

                if (arr[mid] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return arr[start];
        }
 
        public static void ce_Main(string[] args)
        {
            int[] arr = { 3, 4, 5, 6, 7, 8, 9 };
            
            Console.WriteLine(Cel_num(arr, 4));
        }
    }
}
