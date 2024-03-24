using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Stack_pr
{
    internal class Insert_an_Element_at_the_Bottom_of_a_Stack
    {
        public Stack<int> insertAtBottom(Stack<int> st, int x)
        {
            Stack<int> ReqStk = new Stack<int>();

            foreach(var s in st)
            {
                ReqStk.Push(s);
            }

            st.Push(x);

            foreach(var r in ReqStk)
            {
                st.Push(r);
            }

            return st;
        }
    }
}
