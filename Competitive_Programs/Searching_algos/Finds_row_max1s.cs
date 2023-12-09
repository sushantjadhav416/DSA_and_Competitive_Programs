using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Searching_algos
{
    internal class Finds_row_max1s
    {

        public static int Find_max1_row(int[,] matrix)
        {
            int i = 0, j = 0,c=0;
            int C1 = 0;
            int[] ar = new int[3];
            while (j <= 2)
            {
                if (matrix[i, j] == 1)
                {
                    C1++;        
                }
               
                j++;
            }

            int a = 1, b = 0;
            int C2 = 0;
            while (b <= 2)
            {
                if (matrix[a, b] == 1)
                {
                    C2++;
                   
                }
               
                b++;
            }

            int p = 2, q = 0;
            int C3 = 0;
            while (q <= 2)
            {
                if (matrix[p, q] == 1)
                {
                    C3++;
                }
              
                q++;
            }
            
            if (C1>C2 && C1>C3)
                return 1;
            if(C2>C1 && C2>C3)
                return 2;

            return 3;
        }

        public static void  Fi_Main(string[] args)
        {
            int[,] matrix = { { 0, 1, 0 }, { 0, 1, 1 }, { 1, 1, 1 } }; 

            Console.WriteLine("The Row with max 1s: {0}",Find_max1_row(matrix));
        }

    }
}
