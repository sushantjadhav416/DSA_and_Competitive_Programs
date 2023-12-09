using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Stack_pr
{
    internal class MyStack
    {
        int[] ar = new int[100];
        int n = 100;
        int top = -1;

        public void Inc() {
            top++;
        }
        public  void Push(int val)
        {
            if (top >= n - 1)
            {
                Console.WriteLine("Stack OverFlow!!!");
            }
            else
            {
                top++;
                ar[top] = val;
            }

        }
        public  void Pop()
        {
            if (top <= -1)
            {
                Console.WriteLine("Stack UnderFlow!!!");
            }
            else
            {
                Console.WriteLine("The Element pushed is{0}", ar[top]);
                top--;
            }

        }
        public  void display()
        {
            if(top>-1) {
                Console.WriteLine("The Elements in Stack is:");
                for(int i = ar.Length; i <= 0; i--)
                {
                    Console.WriteLine(ar[i]+" ");
                }
            }
            else
            {
                Console.WriteLine("The Stack is empty");
            }

        }
        public static void st_Main(string[] args)
        {
            int c = 1;
           
            MyStack st = new MyStack();
           // st.Inc();
           // Console.WriteLine(static.top);

            while (c != 0)
            {
                Console.WriteLine("1) Push: ");
                Console.WriteLine("2) POP: ");
                Console.WriteLine("3) Display:");
                Console.WriteLine("4) Exit:");
               
                string s  = Console.ReadLine();
               
                if (s.Equals("1"))
                {
                    
                    Console.WriteLine("Enter the value to be pused:");
                    int n = Convert.ToInt32(Console.ReadLine());
                    st.Push(n);
                }
                else if (s.Equals("2")) 
                {
                    st.Pop();
                }
                else if(s.Equals("3")) 
                {
                    st.display();
                }
                else if( s.Equals("4"))
                {
                    c = 0;
                }

            }
        }
    }
}
