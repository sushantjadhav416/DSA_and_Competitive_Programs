using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.String_programes
{
    internal class Roman_to_number
    {
        public int value(char c)
        {
            if (c == 'I')
                return 1;
            if (c == 'V')
                return 5;
            if (c == 'X')
                return 10;
            if (c == 'L')
                return 50;
            if (c == 'C')
                return 100;
            if (c == 'D')
                return 500;
            if (c == 'M')
                return 1000;
            return -1;

        }
        //input:IC;
        //OUTPUT:99;

        //input:IV;
        //OUTPUT:4;

        public int romanToDecimal(string str)
        {
            // code here
            int res = 0;

            for (int i = 0; i < str.Length; i++)
            {

                int s1 = value(str[i]);

                if (i + 1 < str.Length)
                {
                    int s2 = value(str[i + 1]);

                    if (s1 >= s2)
                    {
                        res = res + s1;
                    }
                    else
                    {
                        res = res + s2 - s1;
                        i++;
                    }
                }
                else
                {
                    res = res + s1;
                }
            }
            return res;
        }

        public static void ro_Main(string[] args)
        {
            string str = Console.ReadLine();
            Roman_to_number r = new Roman_to_number();
            Console.WriteLine(r.romanToDecimal(str));
        }
    }
}
