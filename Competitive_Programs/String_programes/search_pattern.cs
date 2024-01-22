using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.String_programes
{
    internal class search_pattern
    {
        public static void search(String pat, String txt)
        {
            // your code here
           
            bool found = false;

            for (int i = 0; i < (pat.Length- txt.Length); i++)
            {
                String str1 = pat.Substring(i, (txt.Length + i));
                if ((pat.Substring(i, (txt.Length + i))).Equals(txt))
                {
                    Console.Write(i+" ");
                    found = true;
                }
                
            }
        }

        public static void Main(String[] args)
        {
            String str1 = "geeksforgeeks";
            String str2 = "geek";

            search(str1,str2);


        }
    }
}
