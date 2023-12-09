using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.String_programes
{
    //Excel column name for column number
    internal class string_number_to_array
    {
        public static string reverse_str(string str)
        {
            char[] arr  = str.ToCharArray();
            Array.Reverse(arr);
           
            return new string(arr);
        }

        public static string num_to_string(int n)
        {
            
            string str = "";

            while (n > 0)
            {
                int rem = n % 26;
                //if reminder is 0 then Z is there
                if (rem == 0)
                {
                    str = str + "Z";
                    n = (n / 26) - 1;
                }
                else
                {
                    str += (char)((rem-1) + 'A');
                    n = n / 26;
                }
            }
            
            return reverse_str(str);

        }

        public static void n_Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num_to_string(n));

        }

        
    }
}
