using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.String_programes
{
    internal class All_permutations
    {
        private static void permute(string str, int l, int r)
        {
            if (l == r)
                Console.WriteLine(str);
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    permute(str, l + 1, r);
                    str = swap(str, l, i);
                }
            }
        }
        /** 
         * Swap Characters at position 
         * @param a string value 
         * @param i position 1 
         * @param j position 2 
         * @return swapped string 
         */
        public static string swap(string a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }

        // Driver Code 
        public static void alp_Main(string[] args)
        {
            string str = "ABC";
            int n = str.Length;

            var my_l = find_permutation(str);

            foreach(var v in my_l)
            {
              Console.WriteLine(v);
            }
        }

        public static List<string> find_permutation(string S)
        {
            // Code here
            string temp = S;

            bool done = true;
            List<string> ou_str = new List<string>();
            ou_str.Add(S);

            while (done)
            {

                char m = S[S.Length - 1];
                string str = m + S.Substring(0, S.Length - 1);

                S = str;

                if (temp == S)
                    break;

                ou_str.Add(str);
            }

            return ou_str;
        }
    }
}
