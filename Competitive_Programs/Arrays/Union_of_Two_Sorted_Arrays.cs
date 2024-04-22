using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Arrays
{


    // VVVIMP 

    internal class Union_of_Two_Sorted_Arrays
    {
        public static List<int> findUnion(int[] arr1, int[] arr2, int n, int m)
        {
            


            List<int> L2 = new List<int>();


            for (int i = 0; i < arr1.Length; i++)
            {
                if (!L2.Contains(arr1[i]))
                {
                    L2.Add(arr1[i]);
                }
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                if (!L2.Contains(arr2[i]))
                {
                    L2.Add(arr2[i]);
                }
            }

            L2.Sort();

            return L2;


        }


        // Union of two sorted arrays Two Pointer Approach 

        public static int nextDistinct(int[] arr, int x)
        {
            while (x < arr.Length - 1 && arr[x] == arr[x + 1])
            {
                x++;
            }
            return x + 1;
        }
        public static List<int> findUnion_(int[] arr1, int[] arr2, int n, int m)
        {



            List<int> L2 = new List<int>();
            int i = 0, j = 0;

            while (i < n && j < m)
            {
                if (arr1[i] < arr2[j])
                {
                    L2.Add(arr1[i]);
                    i = nextDistinct(arr1, i);

                }
                else if (arr1[i] > arr2[j])
                {
                    L2.Add(arr2[j]);
                    j = nextDistinct(arr2, j);
                }
                else
                {
                    L2.Add(arr1[i]);
                    i = nextDistinct(arr1, i);
                    j = nextDistinct(arr2, j);
                }
            }

            while (i < n)
            {
                L2.Add(arr1[i]);
                i = nextDistinct(arr1, i);
            }

            while (j < m)
            {
                L2.Add(arr2[j]);
                j = nextDistinct(arr2, j);
            }

            return L2;

        }


    }
}
