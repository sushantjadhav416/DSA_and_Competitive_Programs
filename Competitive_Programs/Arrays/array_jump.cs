using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Arrays
{
    internal class array_jump
    {

        public static int minimun_jumps(int[] arr)
        {
            if (arr.Length < 0)
                return 0;

            int maxReach = arr[0];
            int step = arr[0];
            int jump = 1;

            for(int i = 1; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                    return jump;

                if (i + arr[i] > maxReach)
                    maxReach = arr[i] + i;
                step--;

                if (step == 0)
                {
                    jump++;
                    step = maxReach - i;
                }
            }
            return jump;

        }
        public static void ju_Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 8, 9, 2, 6, 7, 6, 8, 9 };

            Console.WriteLine(minimun_jumps(arr));
        }
       

    }
}
