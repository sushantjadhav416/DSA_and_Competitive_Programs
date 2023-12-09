using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.String_programes
{
    internal class Remove_anagram
    {

        public static List<string> Rm_ana(List<string> ls)
        { 
            List<string> my_list = new List<string>();

            HashSet<string> set = new HashSet<string>();    

            for(int i=0; i<ls.Count; i++) 
            { 
              string str  = ls[i];

              str = sort(str);


                if (!set.Contains(str))
                {

                    my_list.Add(ls[i]);
                    set.Add(str);
                }
            }
            my_list.Sort();     
            return my_list;
        }
        public static string sort(string str)
        {
            char[] carray = str.ToCharArray();
            Array.Sort(carray);

            return string.Join("", carray);
        }

        public static void ana_Main() { 
               
            List<string> ls = new List<string>{ "geeks", "keegs", "code", "doce" };
            ls.Max();
            var r_out = Rm_ana(ls);

            foreach(string str in r_out)
            {
                Console.WriteLine(str);
            }
        }

    }
}
