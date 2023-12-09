using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.String_programes
{
    internal class Look_and_say
    {

        public static string L_A_S(int n)
        {
            if(n==1)
                return "1";
            if(n==2)
                return "11";

            string str = "11";
            for (int i = 3; i <= n; i++)
            {
                str += '$';
                string temp = "";
                int c = 1;

                char[] arr = str.ToCharArray();
                for (int j = 1; j < str.Length; j++)
                {

                    if (arr[j] != arr[j-1])
                    {
                        temp += c + 0;
                        temp += arr[j-1];
                        c = 1;
                    }
                    else
                    {
                        c++;
                    }
                    
                }
                str = temp;
               
            }
            return str;
        }

        public static void lo_Main(string[] args) {

            int n = 3;
           Console.WriteLine(L_A_S(n));
        }
    }
}
