using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.String_programes
{
    internal class least_occured_char
    {
        public static char l_o_c(string str)
        {
           Dictionary<char,int> my_dict = new Dictionary<char,int>();

            for(int i = 0; i < str.Length; i++)
            {
                if (my_dict.ContainsKey(str[i]))
                {
                    my_dict[str[i]] += 1;
                }
                else
                {
                   my_dict[str[i]] = 1;
                }
            }
            var o = my_dict.Min(x => x.Value);
            var ou = my_dict.FirstOrDefault(x => x.Value == o ).Key;

            return ou;
        }

        public static void le_Main(string[] args)
        {
              string str = Console.ReadLine();
            Console.WriteLine(l_o_c(str));
        }
    }
}
