using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.String_programes
{
    internal class Repalce_vowels
    {
        public static void R_vowels(List<string> ls,char ch)
        {
            List<char> v_list = new List<char>() { 'A','E','I','O','U','a','e','i','o','u'};

            for(int i = 0; i < ls.Count; i++)
            {
                for(int j = 0; j < v_list.Count; j++)
                {
                    ls[i] = ls[i].Replace(v_list[j],ch);

                }
                Console.WriteLine(ls[i]);
            }
        }

        public static void rp_Main(string[] args) 
        {

            List<string> ls = new List<string>() {"Sushant","Vikas","Jadhav","Kichten","tech"};

            R_vowels(ls,'@');
        }
    }
}
