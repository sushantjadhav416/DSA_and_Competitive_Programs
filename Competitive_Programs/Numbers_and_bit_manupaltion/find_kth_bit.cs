using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Numbers_and_bit_manupaltion
{
    internal class find_kth_bit
    {
       

        public static void d_to_b(int n, int k)
        {

            string s = "";
            while (n > 0)
            {
                int rem = n % 2;

                s = rem+s;
                n = n >> 1;
            }
           

            if (k < s.Length)
            {
                Console.WriteLine(s);
                Console.WriteLine(s[k-1]);
            }
            else
            {

                Console.WriteLine("The number does not consist kth bit");
            }
        }

        public static int Setith(int n,int i)
        {
            return n | (1<<i);
        }

        public static int Clearith(int n, int i)
        {
            int mask = ~(1 << i);

            return n & mask;

        }
        public static void fkb_Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            d_to_b(n, k);
            Console.WriteLine(Setith(n,k));
            Console.WriteLine(Clearith(n,k));
           
        }

    }
}
