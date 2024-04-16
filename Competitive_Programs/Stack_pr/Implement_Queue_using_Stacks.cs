using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Stack_pr
{
    internal class Implement_Queue_using_Stacks
    {
        private Stack<int> First;
        private Stack<int> second;

        public Implement_Queue_using_Stacks()
        {
            First = new Stack<int>();
            second = new Stack<int>();
        }

        public void push(int x)
        {
            First.Push(x);
        }

        public int pop()
        {
            while (First.Count()==0) 
            {
                second.Push(First.Pop());
            }

            int vari = second.Pop();

            while (second.Count()==0)
            {
                First.Push(second.Pop());
            }
            return vari;
        }

        public int peek()
        {
            while (First.Count() == 0)
            {
                second.Push(First.Pop());
            }

            int vari = second.Pop();

            while (second.Count() == 0)
            {
                First.Push(second.Pop());
            }
            return vari;

        }

        public bool empty()
        {
            return First.Count()==0;
        }
    }
}
