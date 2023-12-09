using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Numbers_and_bit_manupaltion
{
	internal class power_of_two
	{
		public static bool power_to(int n)
		{
			if (n == 0)
				return false;

			while (n != 1)
			{
				if (n % 2 != 0)
					return false;
				n = n >> 1;
			}

			return true;
		}
	}
}
