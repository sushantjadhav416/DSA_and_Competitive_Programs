using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Sliding_window
{
    internal class Maximum_of_all_subarrays_of_size_k
    {
        static List<int> max_of_subarrays(int[] arr, int n, int k)
        {
            List<int> Al = new List<int>();
            int j, max = 0;
            for (int i = 0; i <= n - k; i++)
            {
                max = arr[i];
                for (j = 1; j < k; j++)
                {
                    if (max < arr[i + j])
                        max = arr[i + j];
                }
                Al.Add(max);
            }

            return Al;
        }
    }
}
