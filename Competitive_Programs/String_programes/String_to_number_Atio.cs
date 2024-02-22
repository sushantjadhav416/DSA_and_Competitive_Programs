using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.String_programes
{
    internal class String_to_number_Atio
    {
        public int myAtoi(String s)
        {
            
            if (s.Length==0)
                return 0;

            int sign = s[0] == '-' ? -1 : 1;
            if (s[0] == '+' || s[0] == '-')
                s = s.Substring(1);

            long num = 0;

            foreach( char c in  s.ToCharArray())
            {
                if (!char.IsDigit(c))
                    break;
                num = num * 10 + (c - '0');
                if (sign * num <= int.MinValue)
                    return int.MinValue;
                if (sign * num >= int.MaxValue)
                    return int.MaxValue;
            }

            return sign * (int)num;
        }
    }
}
