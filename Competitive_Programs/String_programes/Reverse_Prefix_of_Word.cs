using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.String_programes
{
    internal class Reverse_Prefix_of_Word
    {
       public string reversePrefix(string word, char ch) 
       {
          string rev = "";
          
          int index = -1;

          for(int i=0;i<word.Length;i++)
         {
           if(word[i]==ch)
           {
               index = i;
               break;
           }
         }

        // for(int i=index;i>=0;i--)
        // {
        //     rev += word.charAt(i);
        // }

        // for(int i=index+1;i<word.length();i++)
        // {
        //     rev += word.charAt(i);
        // }

          if(index!=-1)
         {
            return new StringBuilder(word.Substring(0,index+1)).Reverse().ToString() + word.Substring(index+1);
         }

     
     
           return word;
       }

        public static void rp_Main(string[] args) 
        {

            
        }
    }
}
