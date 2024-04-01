using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Matrix
{
    internal class Search_a_2D_Matrix
    {
        public bool searchMatrix(int[][] matrix, int target)
        {
             if (matrix.Length == 0)
                return false;

             int m = matrix.Length;
             int n = matrix[0].Length;

             int l = 0;
             int r = m * n;

            while (l < r)
            {
                int mid = (l + r) / 2;

                int i = mid / n;

                int j = mid % n;


                if (matrix[i][j] == target)
                    return true;

                if (matrix[i][j] < target)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid;
                }
            }

            return false;



        }
    }
}
