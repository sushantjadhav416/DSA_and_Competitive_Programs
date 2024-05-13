using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Matrix
{
    internal class Largest_Local_Values_in_a_Matrix
    {

       public int[,] LargestLocal(int[][] grid) 
      {
        int n = grid.Length;

        int[,] res = new int[n-2,n-2];

        for(int i=1;i<n-1;++i)
        {
            for(int j=1;j<n-1;++j)
            {
                int temp = 0;
                for(int k=i-1;k<=i+1;++k)
                {
                    for(int l=j-1;l<=j+1;l++)
                    {
                        temp = Math.Max(temp,grid[k][l]);
                    }
                }

                res[i-1,j-1]=temp;
            }
        }

        return res;
      }
      public static void so_Main(string[] args)
      {
            int[,] arr = { { 43, 42, 54},{ 65, 76, 87 }, { 91, 34, 54 } };
            // mat_sort(arr);
      }
    }
}
