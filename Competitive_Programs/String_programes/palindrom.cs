using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs
{
    internal class palindrom
    {
       
        public static void pal_Main(string[] args)
        {
            string inp = Console.ReadLine();
            string rev = "";
            char c;

            for (int i = 0; i < inp.Length; i++)
            {
                c = inp[i];
                rev = c + rev;
            }

            Console.WriteLine(inp.Equals(rev)?"Palindrom":"Not Palindorm");
        }

}
}
