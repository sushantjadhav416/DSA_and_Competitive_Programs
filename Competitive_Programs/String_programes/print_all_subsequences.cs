using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.String_programes
{
    internal class print_all_subsequences
    {
        static List<string> subsequences = new List<string>();
        
        public   void subseq(string st,string ans)
        {
            if(st.Length == 0)
            {
               subsequences.Add(ans);
                return;
            }

            subseq(st.Substring(1), ans + st[0]);

            subseq(st.Substring(1), ans);


        }
        //input = abcd
        public static void ps_Main(string[] args)
        {
            print_all_subsequences ps = new print_all_subsequences();
            string s =  Console.ReadLine();
            ps.subseq(s,"");
            
            for(int i=0;i<subsequences.Count;i++)
            {
                Console.WriteLine(subsequences.ElementAt(i));
            }
        }
    }
}
