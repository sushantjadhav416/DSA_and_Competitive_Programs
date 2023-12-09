//Ver very  IMP
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Arrays
{
    internal class Height_difference
    {

        public static int max_min_h_d(int[] arr,int n,int k)
        {
            Array.Sort(arr);
            int ans = (arr[n - 1] + k) + (arr[0] + 1); // Maximum possible height difference
           
            int tempmax = arr[n - 1] - k;

            int tempmin = arr[0] + k;

            int max,min;

            for(int i=0; i<n-1; i++)
            {
                if(tempmax > (arr[i] + k))
                {
                    max = tempmax;
                }
                else
                {
                    max = arr[i] + k;
                }

                if (tempmin < (arr[i+1] - k))
                {
                    min = tempmin;
                }
                else
                {
                    min = arr[i+1] - k;
                }

                if(ans > (max - min))
                {
                    ans = max - min;
                }

            }

            return ans;

        }
        public  static void di_Main()
        {

            int[] arr = { 7, 4, 8, 8, 8, 9 };

           Console.WriteLine( max_min_h_d(arr, arr.Length, 6));

        }
    }
}
