using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Matrix
{
    internal class sum_of_digonal
    {
        public static void sum_digonal(int[,] mat,int n )
        {
            int p_sum = 0;
            int s_sum = 0;
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                { 
                    if(i==j)
                       p_sum += mat[i,j];
                    if(i+j == n-1)
                       s_sum += mat[i,j];
                }
            }
            Console.WriteLine("Principale digonal sum={0}", p_sum);
            Console.WriteLine("Secondary digonal sum={0}",s_sum);
        }
        public static void di_Main(string[] args)
        {
            int[,] matrix = new int[3,3];

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    matrix[i,j]= Convert.ToInt32(Console.ReadLine());
                }
               
            }  
            
           sum_digonal(matrix,3);
        }


    }
}
