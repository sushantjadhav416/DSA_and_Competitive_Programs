using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Numbers_and_bit_manupaltion
{
    internal class LCM_number
    {

        public static int GCD(int a,int b) 
        {
            if (a == 0)
                return b;
            return GCD(b % a, a);
        }

        public static int lcm(int a,int b)
        {
            return (a/GCD(a,b))*b;
        }

        public static int  fastpower(int n,int p)
        {
            int res = 1;
            while (p > 0)
            {
                if ((p % 1 != 0))
                {
                    res = res * n;
                }
                n = n * n;
                p = p >> 1;
            }
            return res;
        }

        public static void lc_Main(string[] args)
        {

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(lcm(a,b));

            Console.WriteLine(GCD(a,b));
        }

    }
}
