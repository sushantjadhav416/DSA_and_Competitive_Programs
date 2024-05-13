using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.String_programes
{
    internal class Valid_palindrom
    {
        public bool isPalindrome(string s) 
       {
           int l = 0;
           int r = s.Length - 1;

           while (l < r)
           {
            //    while (l < r && !character.isLetterOrDigit(s.charAt(l)))
            //      ++l;
            //    while (l < r && !Character.isLetterOrDigit(s.charAt(r)))
            //      --r;
            //    if (Character.toLowerCase(s.charAt(l)) != Character.toLowerCase(s.charAt(r)))
            //       return false;
            //    ++l;
            //    --r;
           }

           return true;
       }
        
        public static void val_Main(string[] args) 
        { 
           string s = Console.ReadLine();

            // validarting(s);
        }
    }
}
