using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Arrays
{
    internal class Array_negative_seperate
    {
        public static void A_N_s(int[] arr, int n)
        {

            int[] temp = new int[n];

            // Traversal array and store +ve element in
            // temp array
            int j = 0; // index of temp

            for (int i = 0; i < n; i++)
                if (arr[i] >= 0)
                    temp[j++] = arr[i];

            // If array contains all positive or all
            // negative.
            if (j == n || j == 0)
                return;

            // Store -ve element in temp array
            for (int i = 0; i < n; i++)
                if (arr[i] < 0)
                    temp[j++] = arr[i];

            // Copy contents of temp[] to arr[]
            for (int i = 0; i < n; i++)
                arr[i] = temp[i];


        }

        public static void n_Main(string[] args)
        {
            int[] arr = { 43, 45, 34, -45, -2, 34, 90, -34, -12, 43, 90 };
            A_N_s(arr, arr.Length);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
}

