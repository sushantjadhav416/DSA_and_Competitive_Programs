using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.String_programes
{
    internal class palindrom_possible_ornot
    {
        //input=sspas
        public static bool pal_pos(string str)
        {
            List<char> p_list = new List<char>();
            
            for(int i = 0; i < str.Length; i++)
            {
                if (p_list.Contains(str[i]))
                {
                    p_list.Remove(str[i]);
                }
                else
                {
                    p_list.Add(str[i]);

                }
            }

            if (str.Length%2==0 && p_list.Count == 0)
            {
                return true;
            }
            else if(str.Length % 2 != 0 && p_list.Count == 1)
            {
                return true;
            }

            return false;

        }

        public static void pal_Main(string[] args)
        {
            string str = Console.ReadLine();

            if(pal_pos(str))
            {
                Console.WriteLine("Palindrom is posible");

            }
            else
            {
                Console.WriteLine("Palindrom is not possible");
            }
        }


    }
}
