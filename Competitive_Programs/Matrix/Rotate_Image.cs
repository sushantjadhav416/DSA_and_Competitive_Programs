using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Matrix
{
    internal class Rotate_Image
    {
        public void rotate(int[][] matrix)
        {
            for (int i = 0, j = matrix.Length - 1; i < j; i++, j--)
            {
                int[] temp = matrix[i];
                matrix[i] = matrix[j];
                matrix[j] = temp;
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = i + 1; j < matrix.Length; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
        }
    }
}
