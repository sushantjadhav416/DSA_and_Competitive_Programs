using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Numbers_and_bit_manupaltion
{
    internal class decimal_to_binary
    {
        public static string rev(string str)
        {
            
            string rev = "";
            char c;

            for (int i = 0; i < str.Length; i++)
            {
                c = str[i];
                rev = c + rev;
            }
            return rev;

        }

        public static void d_to_b(int n, int k)
        {

            string s = "";
            while (n > 0)
            {
                int rem = n % 2;

                s = s + rem;
                n = n >> 1;
            }
            string ou = rev(s);

            if(k<s.Length) {
                Console.WriteLine(ou);
                Console.WriteLine(ou[k - 1]);
            }
            else {

                Console.WriteLine("The number does not consist kth bit");
            }

           
        }

        public static void db_Main(string[] args)
        {
            
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());    
           // d_to_b(n,k);
          


        }


    }

}
