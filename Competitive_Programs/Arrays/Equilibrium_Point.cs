using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Arrays
{
    internal class Equilibrium_Point
    {
        public static bool is_equi(long[] arr, int m)
        {
            long sum1 = 0;
            for (int i = 0; i < m; i++)
            {
                sum1 = sum1 + arr[i];
            }

            long sum2 = 0;
            for (int i = m + 1; i < arr.Length; i++)
            {
                sum2 = sum2 + arr[i];
            }


            return sum1 == sum2;
        }

        public static int equilibriumPoint(long[] arr, int n)
        {
            // Your code here

            if (arr.Length == 1)
                return 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (is_equi(arr, i))
                    return (i + 1);
            }
            return -1;

           


            

        }
    }
}
