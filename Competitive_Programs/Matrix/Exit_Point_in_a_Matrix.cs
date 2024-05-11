using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Matrix
{
    internal class Exit_Point_in_a_Matrix
    {
        public int[] FindExitPoint(int n, int m, int[,] matrix)
        {
            // code here
            int i = 0, j = 0;

            int dir = 0;

            while (true)
            {
                dir = (dir + matrix[i,j]) % 4;

                if (matrix[i,j] == 1)
                {
                    matrix[i,j] = 0;
                }

              
                // Right direction
                if (dir == 0)
                {
                    j++;
                }
                // Down direction
                else if (dir == 1)
                {
                    i++;
                }
                // Left direction
                else if (dir == 2)
                {
                    j--;
                }
                // Up direction
                else if (dir == 3)
                {
                    i--;
                }


                // decrement either the row or col
                // since it crossed the boundary
                if (i < 0)
                {
                    i++;
                    break;
                }
                else if (i == matrix.Length)
                {
                    i--;
                    break;
                }
                else if (j < 0)
                {
                    j++;
                    break;
                }
                else if (j == matrix.Length)
                {
                    j--;
                    break;
                }


            }

            int[] v = new int[] { i, j };

            return v;

        }
    }
}
