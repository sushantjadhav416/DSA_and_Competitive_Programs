using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.String_programes
{
    internal class Max_char
    {

        public static int maxi(int[] arr)
        {
            int mx = arr[0];
            for(int i=0;i<arr.Length; i++) {
                if (arr[i] > mx)
                {
                    mx = arr[i];
                }
            }

            return mx;
        }
        public static char max_c(string str)
        {
            int c = 0;
            int[] char_count = new int[str.Length];
            for(int i=0; i < str.Length; i++)
            {
                for(int j=0;j<str.Length;j++)
                {
                    if (str[i] == str[j])
                    {
                        c++; 
                    }

                }
                char_count[i] = c;
                c = 0;
            }

            int max = maxi(char_count);

            int outin = Array.FindIndex(char_count,x=> x.Equals(max));

            return str[outin];
        }

        static char majorityElement(string str, int size)
        {
            // your code here
            int maxcount = 0;
            int index = -1;

            for (int i = 0; i < size; i++)
            {
                int count = 0;

                for (int j = 0; j < size; j++)
                {
                    if (str[i] == str[j])
                    {
                        count++;
                    }
                }

                if (count > maxcount)
                {
                    maxcount = count;
                    index = i;
                }
            }

            if (size == 1)
                return str[0];
            else if (maxcount > size / 2)
                return str[index];

            return str[index];
           // return -1;
        }

        public static void maj_Main(string[] args) 
        { 
            string str = Console.ReadLine();
            
           Console.WriteLine(max_c(str));
           Console.WriteLine(majorityElement(str,str.Length));

        }  
    }
}
