using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Matrix
{
    internal class Set_Matrix_Zeroes<T>
    {
        public void setZeroes(int[][] matrix)
        {
            int row = matrix.Length;
            int col = matrix[0].Length;

            HashSet<int> Hset1 = new HashSet<int>();

            HashSet<int> Hset2 = new HashSet<int>();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        Hset1.Add(i);
                        Hset2.Add(j);
                    }
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (Hset1.Contains(i) || Hset2.Contains(j))
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

        }
    }
}
