using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Searching_algos
{
    internal class binary_serach
    {
        public static int b_serach(int[] arr,int n)
        {
            int l = 0,r=arr.Length-1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                if (arr[m] == n)  
                    return m;

                if (arr[m] < n)
                    l = m + 1;
                else
                    l = m - 1;
                    
            }

            return -1;
        }
        public static void bs_Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            Console.WriteLine("The element is at:{0}",b_serach(arr,7));



        }
    }
}
