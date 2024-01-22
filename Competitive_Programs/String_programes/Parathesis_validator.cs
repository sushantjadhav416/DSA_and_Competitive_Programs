using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.String_programes
{
    internal class Parathesis_validator
    {
        public bool myParathesis_validator(string s)
        {
           // int c1 = 0;
            //     int c2 = 0;
            //     int c3 = 0;
            //     for(int i=0;i<s.length();i++)
            //     {
            //         if(s.charAt(i)=='(')
            //         {
            //              c1 = c1 +1;
            //         }
            //         else if(s.charAt(i)==')')
            //         {
            //              c1 = c1 -1;
            //         }

            //         if(s.charAt(i)=='{')
            //         {
            //              c2 = c2 +1;
            //         }
            //         else if(s.charAt(i)=='}')
            //         {
            //              c2 = c2 - 1;
            //         }

            //         if(s.charAt(i)=='[')
            //         {
            //             c3=c3+1;
            //         }
            //         else if(s.charAt(i)==']')
            //         {
            //             c3=c3-1;
            //         }

            //     }

            //     if(c1==0 && c2==0 && c3==0)
            //       return true;

            //  return false;
            Stack<char> stack = new Stack<char>();
            char[] myarr = s.ToCharArray();
            foreach(char c in myarr)
            {
                if (c == '(')
                    stack.Push(')');
                else if (c == '{')
                    stack.Push('}');
                else if (c == '[')
                    stack.Push(']');
                else if (stack.Count()==0 || stack.Pop() != c)
                    return false;
            }

            return stack.Count()==0;
        }
    }
}
