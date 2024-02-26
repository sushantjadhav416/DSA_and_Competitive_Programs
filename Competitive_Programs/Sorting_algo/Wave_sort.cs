using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Sorting_algo
{
    internal class Wave_sort
    {
        public static void convertToWave(int n, int[] a)
        {
            // code here

            if (a.Length % 2 == 0)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (i == 0 || i % 2 == 0)
                    {
                        int temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                    }
                }
            }
            else
            {
                for (int i = 0; i < n - 2; i++)
                {
                    if (i == 0 || i % 2 == 0)
                    {
                        int temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                    }
                }
            }
        }
    }
}
