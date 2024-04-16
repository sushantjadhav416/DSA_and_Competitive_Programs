using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Competitive_Programs_and_DSA_Qns.Stack_pr
{
    internal class Implement_Stack_using_Queues
    {
        Queue<Integer> MQ;

        public MyStack()
        {
            MQ = new LinkedList<Integer>();
        }

        public void push(int x)
        {
            MQ.add(x);
            for (int i = 0; i < MQ.size() - 1; i++)
            {
                MQ.add(MQ.remove());
            }
        }

        public int pop()
        {
            return MQ.remove();
        }

        public int top()
        {
            return MQ.peek();
        }

        public Bool empty()
        {
            return MQ.size() == 0;
        }
    }
}
