using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.String_programes
{
    internal class edit_distance
    {
        public static int minimum(int x, int y,int z)
        {
            if (x<y && x < z)
            {
                return x;
            }
            else if (y<x && y < z)
            {
                return y;
            }
            return z;
        }

        public static int  ed_distance(string str1,string str2, int n,int m)
        { 
            if(m==0)
                return n;
            if(n==0)
                return m;

            if (str1[n-1] == str2[m-1])
                return ed_distance(str1,str2,n-1,m-1);

            return 1+minimum(ed_distance(str1, str2,n,m-1),ed_distance(str1, str2, n-1, m),ed_distance(str1, str2, n-1, m - 1));
        }

        public static void ed_Main(string[] args) { 

            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            Console.WriteLine(ed_distance(str1,str2,str1.Length,str2.Length));
        
        }
    }
}
