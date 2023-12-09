using Competitive_Programs.Stack_pr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Arrays
{
    internal class Interval
    {
       public int Start, End;
       public Interval(int Start, int End)
        {
            this.Start = Start; 
            this.End = End;
        }

    }
    class SortHelper: IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            Interval first = (Interval)x;
            Interval second = (Interval)y;
            if(first.Start == second.Start)
            {
                return first.End - second.End;
            }
            return first.Start - second.Start;
        }
    }

    internal class MergeOverlappingInterval
    {

        public static void MirgeInterval(Interval[] arr)
        {
            if (arr.Length== 0) return;

            Array.Sort(arr, new SortHelper());

            Stack stck = new Stack();

            stck.Push(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                Interval top = (Interval)stck.Peek();

                if (top.End < arr[i].Start)
                    stck.Push(arr[i]);

                else if (top.End < arr[i].End)
                {
                    top.End = arr[i].End;  
                    stck.Pop();  
                    stck.Push(top);  
                }

            }
            // Print contents of stack
            Console.Write("The Merged Intervals are: ");
            while (stck.Count != 0)
            {
                Interval t = (Interval)stck.Pop();
                Console.Write("[" + t.Start + "," + t.End + "] ");
            }
        }

        public static void stm_Main(string[] args)
        {
            Interval[] arr = new Interval[4];

            arr[0] = new Interval(6, 8);
            arr[1] = new Interval(1, 4);
            arr[2] = new Interval(6, 10);
            arr[3] = new Interval(1, 5);
            
            MirgeInterval(arr);
        }
      
    }
}
