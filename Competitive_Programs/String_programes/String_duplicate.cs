using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.String
{
    internal class String_duplicate
    {
         public static void dup_find(string str)
        {
            char[] arr = str.ToCharArray();
            
            int c = 0;
     
            int[] ch_count = new int[arr.Length];

            for(int i = 0; i < str.Count(); i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    if (str[i] == arr[j])
                    {
                        c++;
                    }
                }
                
               ch_count[i] = c;
               c = 0;
            }
           var cset = new HashSet<int>(ch_count);
           var set  = new HashSet<char>(arr);
            Console.WriteLine(cset.Count);
            Console.WriteLine(set.Count);

            for (int i = 0; i < set.Count; i++)
            {
                Console.WriteLine(set.ElementAt(i) + " | " + cset.ElementAt(i));
                
            }
              
        }

        public static void si_Main(string[] args)
        {
         
            string str = Console.ReadLine();   
            
            dup_find(str);

        }
    }
}
