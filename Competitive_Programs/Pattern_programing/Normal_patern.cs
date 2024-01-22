using System;
using System.Collections.Generic;
using System.Data;
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
            int k = 1;
            int p = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    //Console.Write("*");
                      Console.Write(p++);
                }
                p=1;
                k++;
                Console.WriteLine();
            }
        }

        public static void reverse_inc(int n)
        {
            int k = n;
            int p = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                   // Console.Write("*");
                   Console.Write(p);
                }
                p--;
                k--;
                Console.WriteLine();
            }
        }

        public static void Rev_inc(int n)
        {
            int p = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {

                    // Console.Write("*");
                    Console.Write(p);
                }
                p++;
                Console.WriteLine();
            }
        }

        public static void Pattern(int n)
        {
            int k = n / 2;
            for(int i = 0; i < n; i++)
            {
                if (i <=n / 2)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }
                else
                {
                    k--;
                    for (int j = 0; j <k; j++)
                    {
                        Console.Write('*');
                    }
                    
                    Console.WriteLine();
                }
            }


        }

        public static void trangle_pattern(int n)
        {
            for(int row = 1;row<=n;row++)
            {
                for(int space =0; space < n-row; space++)
                    Console.Write(" ");

                for(int col=row; col>=1;col--)
                 Console.Write(col); 

                for(int col=2; col <= row ; col++)
                 Console.Write(col);

                Console.WriteLine();

            }

        }
        public static void Dimond_pattern(int n)
        {
            
            for (int row = 1; row < n*2; row++)
            {
                int c = row > n ? n*2-row-1:row-1;
                for (int space = 0; space < n - c; space++)
                    Console.Write("  ");

                for (int col = c; col >= 1; col--)
                    Console.Write(col+" ");

                for (int col = 2; col <= c ; col++)
                    Console.Write(col+" ");

                Console.WriteLine();

            }

        }

        public static void Pascals_triangle(int newRow)
        {


        }


        public static void P_Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            
            //Rev_inc(n);
            //reverse_inc(n);
           // Console.WriteLine();
           // increamental_pat(n);

           // Pattern(n);
            Dimond_pattern(n);
            
        }
    }
}
