using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Numbers_and_bit_manupaltion
{
	internal class Count_flipped_bits
	{
		public static int count_f_bits(int n,int m)
		{
			int c = 0;
			
			while (n > 0 || m>0)
			{
				int rem1= n % 2;
				int rem2 = m % 2;

				if(rem1 != rem2)
				{
					c++;
				}
				

				n = n >> 1;
				m = m >> 1;
			}

			return c;

		}

		public static void CfB_Main(string[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			int m = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(count_f_bits(n,m));
		}
	}

}
