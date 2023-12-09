using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Matrix
{
    internal class Matrix_median
    {
        public static int find_median(List<List<int>> matrix) {

            List<int> arr= new List<int>();
            foreach(var item in matrix)
            {
                arr.AddRange(item);
            }

            int mid = arr.Count/2;
            int midean = 0;
            arr.Sort();

            if (arr.Count % 2 == 0)
            {
                midean = (arr[mid - 1] + arr[mid])/2;
            }
            else
            {
                midean = (arr[mid]);
            }
            return midean;
        }
        public static double find_median_1d(int[] arr)
        {

            Array.Sort(arr);

            double median = 0;

            int mid  = arr.Length/2;

            if (mid % 2 == 0)
            {
              median = (arr[mid - 1] + arr[mid])/2;
            }
            else
            {
                median= arr[mid]; 
            }

            return median;
        }

        public static void fi_Main(string[] args)
        {
            List<List<int>> matrix1 = new List<List<int>>
            {
                new List<int> { 1, 3, 5 },
                new List<int> { 2, 6, 9 },
                new List<int> { 3, 6, 9 }
            };
            double median1 = find_median(matrix1);
            Console.WriteLine("Median of matrix1: " + median1);

            int[] arr = { 1, 2, 3, 7, 9, 67, 87, 9 };

            Console.WriteLine("The median:{0}",find_median_1d(arr));

        }
    }
}
