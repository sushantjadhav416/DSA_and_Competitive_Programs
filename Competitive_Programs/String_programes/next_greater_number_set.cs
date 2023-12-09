using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.String_programes
{
    internal class next_greater_number_set
    {
        //input= 143;
        public static int ne_great_num(int n)
        {
            int temp = n;
            int rem = 0;
            List<int> n_list = new List<int>();
            bool done = true;

            while(done)
            {
                string s = n.ToString();

                rem = n % 10;

                string d = rem.ToString();

                string ou  = "" + d + s.Substring(0,s.Length-1);

               // Console.WriteLine(ou);

                int num = Convert.ToInt32(ou);

                n_list.Add(num);

                n = Convert.ToInt32(ou);

                if (temp == n)
                    done = false;
            }

            n_list.Sort();

            for (int i=0; i<n_list.Count; i++)
            {
                if(temp < n_list[i])
                {
                    return n_list[i];
                   
                }
            }
            return -1;
        }

        public static void next_Main(string[] args) 
        {

            int n = Convert.ToInt32(Console.ReadLine());

            if (ne_great_num(n) == -1)
            {
                Console.WriteLine("Not possible!");

            }
            else
            {
                Console.WriteLine(ne_great_num(n));
            }
        }


    }
}
