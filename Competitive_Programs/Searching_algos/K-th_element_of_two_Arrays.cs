using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Searching_algos
{
    internal class K_th_element_of_two_Arrays
    {
        public long kthElement(int[] arr1, int[] arr2, int n, int m, int k_req)
        {
            int i = 0, j = 0, k = 0;
            while (i < n && j < m)
            {
                if (arr1[i] < arr2[j])
                {
                    k++;
                    if (k == k_req)
                        return (long)arr1[i];
                    i++;
                }
                else
                {
                    k++;
                    if (k == k_req)
                        return (long)arr2[j];
                    j++;
                }
            }

            while (i < n)
            {
                k++;
                if (k == k_req)
                    return (long)arr1[i];
                i++;
            }

            while (j < m)
            {
                k++;
                if (k == k_req)
                    return (long)arr2[j];
                j++;
            }

            return -1;
        }
    }
}
