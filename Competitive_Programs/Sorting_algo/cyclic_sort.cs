using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Sorting_algo
{
    internal class cyclic_sort
    {
        public static void sort(int[] arr)
        {
            int i = 0;
            while(i  < arr.Length)
            {
                int correct = arr[i] - 1;
                if (arr[i] != arr[correct])
                {
                    int temp = arr[i];
                    arr[i] = arr[correct];
                    arr[correct] = temp;
                }
                else
                {
                    i++;
                }
            }
        }

        public static void cy_Main(string[] args)
        {
            int[] arr = { 4, 2, 3, 5, 1 };
            sort(arr);
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
}
