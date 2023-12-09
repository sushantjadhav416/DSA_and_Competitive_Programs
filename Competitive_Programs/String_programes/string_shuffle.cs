using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.String_programes
{
    internal class string_shuffle
    {
        public static string Sorts(string s)
        {

            char[] str  = s.ToCharArray();

            Array.Sort(str);

            return string.Join("", str);

        }

        public static bool isShuffle(string s1 , string s2)
        {
            int n  = s1.Length;
            int m = s2.Length;

            if(n>m)
            {
                return false;

            }
            else
            {
                s1 = Sorts(s1);

                for(int i= 0; i < m; i++)
                {
                    if(i+n-1 >= m)
                        return false;

                    string str = "";

                    for(int j= 0; j < n; j++)
                         str += s2[i + j];

                    str = Sorts(str);

                    if (str.Equals(s1))
                        return true;
                }

            }
           return false;

        }

        public static void s_Main(string[] args)
        {
            string s1= "onetwofour";
            string s2 = "hellofourtwooneworld";
            string s = "3";
            

            Console.WriteLine(s2.Contains(s1));

            if (isShuffle(s1, s2))
            {
                Console.WriteLine("Yes Suffle");
            }
            else
            {
                Console.WriteLine("No!");
            }
        }

    }
}
