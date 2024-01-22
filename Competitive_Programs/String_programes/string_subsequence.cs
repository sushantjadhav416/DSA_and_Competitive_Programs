using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.String_programes
{
    internal class string_subsequence
    {
        //AACBBfDD
        public static int sub_substring(string str1)
        {
            int count1=0;
            int count2=0;

            char[] str_arr =str1.ToCharArray();
            for(int i=0; i < str1.Count(); i++)
            {
                
                 for(int j=0; j < str_arr.Length; j++)
                {
                    if (str1[i].Equals(str_arr[j]))
                    {
                         count1++;
                    }
                }
                if (count1 > 1)
                {
                    count2=count2+count1-1;
                }
                count1 = 0;
            }
            return count2/2;
        }
       public static void sub_Main(string[] args)
        {

            string str = "CAAADGGJTT";
            Console.WriteLine(sub_substring(str));

        }

        
    }
}
