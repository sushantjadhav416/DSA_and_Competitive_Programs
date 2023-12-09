using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Searching_algos
{
    internal class Searching_better_tc_sc
    {
        public static void serching(int[,] a,int n)
        {
            int c = 0;
            int i = 0;int j = 3;

            while(i<3 && j>=0) {

                if (a[i,j] == n)
                {
                    Console.WriteLine("The element is  at:({0},{1})", i, j);
                    c++;
                    break;
                }

                if (a[i,j]>n)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }
            if (c<=0)
            {
                Console.WriteLine("The element not found!!");
            }

        }
        public static void si_Main(string[] args)
        {
            int[] arr = { 3, 4, 5, 2, 7, 8 };
            int[,] arr_2d = { { 4, 2, 1 ,8}, { 8, 7, 3 ,6}, { 6, 8, 9 ,0} };
            serching(arr_2d, 0);
        }
    }
}
