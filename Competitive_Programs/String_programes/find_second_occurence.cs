using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.String_programes
{
    internal class find_second_occurence
    {
        public static void  second_ocu(List<string> ls ,string str)
        {
            int myin=0;
            int c = 0;
           

            for(int i=0; i<ls.Count; i++) 
            {
                //Console.WriteLine(ls[i]);
                string s = ls[i];
                if (s.Equals(str))
                    c++;

                if (c == 2)
                    myin=i;
            }

            Console.WriteLine(myin);
           
        }

        public static void findsain(string[] args)
        {
            List<string> my_str = new List<string>() { "Vivek", "sushant", "jadhav", "ritesh","sushant","vivek","ritesh" ,"mansi","sushant","viren"};

            second_ocu(my_str, "sushant");
        }
    }
}
