using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.String_programes
{
    internal class reverse_Wordsin_string
    {
        public static void Reverse_word_string(string s)
        {
            string[] strings = s.Split().ToArray();
           
            string out_str = "";
            for(int i=0; i<strings.Length; i++)
            {
                string ou = strings[i];

                string str = "";
                char c;
                char[] inp = ou.ToCharArray();
                int j = 0;
                for ( j = 0; j < inp.Length; j++)
                {
                    c = inp.ElementAt(j);
                    str = c + str;
                }
                if (i != inp.Length - 1)
                {
                    out_str += str + " ";
                }
                else
                {
                    out_str += str ;
                }

            }
            Console.WriteLine(out_str);
        }

        public static void rs_Main(string[] args) {
            string s = "sushnat vikas jadhav";

            Reverse_word_string(s);

        }

    }
}
