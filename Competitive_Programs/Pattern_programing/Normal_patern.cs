using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Pattern_programing
{
    internal class Normal_patern
    {

        public static void normal_pat(int n)
        {
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine();
            }

        }

        public static void increamental_pat(int n)
        {
            int k =1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write("*");
                }
                k++;
                Console.WriteLine();
            }
        }

        public static void reverse_inc(int n)
        {
            int k = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write("*");
                }
                k--;
                Console.WriteLine();
            }
        }
        public static void pa_Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            
            reverse_inc(n);
        }
    }
}
