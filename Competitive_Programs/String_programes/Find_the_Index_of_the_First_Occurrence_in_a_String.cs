using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.String_programes
{
   
    internal class Find_the_Index_of_the_First_Occurrence_in_a_String
    {
        public int strStr(string haystack, string needle) {

        int m = haystack.Length;
        int n = needle.Length;

        for(int i=0;i<m-n+1;i++)
        {
           if(haystack.Substring(i,i+n).Equals(needle))
           {
                return i;
           } 
        }  
        
        return -1;  
    }

        public static void r_Main(string[] args)
        {


        }

    }
}
