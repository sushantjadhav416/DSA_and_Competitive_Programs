using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs
{
    internal class String_rev
    {
        public static  void c_Main(string[] args)
        {
             string inp = Console.ReadLine();
             string str = "";
             char c;

             for(int i = 0; i < inp.Length; i++)
            {
                c = inp.ElementAt(i);
                str = c + str;
            }
             Console.WriteLine(str);
            
        }    
    }
}
