using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Collections;

namespace Competitive_Programs.String_programes
{
    internal class Word_break
    {

        public static bool W_br(List<string> my_ls,string str)
        {

            if(str=="")
                return true;
            

            int slen= str.Length;

            return Enumerable.Range(1,slen).Any(x=>my_ls.Contains(str.Substring(0,x))&& W_br(my_ls,str.Substring(x)));
        }

        public static void wr_Main(string[] args)
        {
            List<string> my_ls = new List<string>{ "mobile", "samsung", "sam", "sung", "man", "mango", "icecream", "and", "go", "i", "like", "ice", "cream" };

            string  s = Console.ReadLine();

            if (W_br(my_ls, s))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


        }
       
    }
}
