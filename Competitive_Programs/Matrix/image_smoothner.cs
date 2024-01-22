using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Matrix
{
    internal class image_smoothner
    {
        public int[,] imageSmoother(int[,] img)
        {
            if (img == null || img.Length == 0 || img.Length == 0)
                  return img;

            int Row = img.Length, column = img.Length;

            int[,] smooth = new int[Row,column];

            int[,] directions = { { -1, -1 }, { -1, 0 }, { -1, 1 }, { 0, 1 }, { 1, 1 }, { 1, 0 }, { 1, -1 }, { 0, -1 } };

            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    int sum = img[i,j];
                    int count = 1;
                    foreach(var direction in directions)
                    {
                      //  int newRow = i + direction[0], newcolum = j + direction[1];
                       // if (newRow >= 0 && newRow < Row && newcolum >= 0 && newcolum < column)
                        {
                      //      sum = sum + img[newRow,newcolum];
                            count++;
                        }
                    }
                    smooth[i,j] = sum / count;
                }
            }
            return smooth;
        }
    }
}
