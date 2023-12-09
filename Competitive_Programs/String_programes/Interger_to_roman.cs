using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.String_programes
{
   
    internal class Interger_to_roman
    {
        public static string I_R_I(int num)
        {
            string[] chars_int = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] int_val = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            string res = "";

            for (int i = 0; i < int_val.Length; i++)
            {
                while (num >= int_val[i])
                {
                    num = num - int_val[i];
                    res = res + chars_int[i];
                }
            }
            return res;
        }

        public static void r_Main(string[] args)
        {


        }

    }
}
