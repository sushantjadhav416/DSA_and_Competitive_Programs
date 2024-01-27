using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.String_programes
{
    internal class Excel_Sheet_Column_Title
    {
        public String convertToTitle(int columnNumber)
        {

            return columnNumber == 0 ? "" : convertToTitle((columnNumber - 1) / 26) + (char)('A' + (columnNumber - 1) % 26);
            // Naive Approach
            //   String s = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            //   int c =0;

            //   if(columnNumber<27)
            //   {
            //        return ""+s.charAt((columnNumber%26)-1);
            //   }
            //   else{
            //       int num = columnNumber;
            //       while(num>0)
            //      {
            //           c++;
            //           num = num-26;
            //      }

            //      int p = columnNumber%26;

            //      return ""+s.charAt(c-2)+s.charAt(p-1);
            //   }

        }

    }
}
