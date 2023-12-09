using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Matrix
{
    internal class Matrix_sorting
    {

        public static void mat_sort(int[,] arr)
        {

            int i = 0, j = 0;

           while (i<3 && j<3)
           {
                Console.WriteLine(arr[i,j]);
                i++;
                j++;
           }
        }
        public static void so_Main(string[] args)
        {
            int[,] arr = { { 43, 42, 54},{ 65, 76, 87 }, { 91, 34, 54 } };
            mat_sort(arr);
        }
    }
}
