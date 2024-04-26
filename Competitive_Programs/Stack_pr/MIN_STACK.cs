
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Competitive_Programs_and_DSA_Qns.Stack_pr{

internal class MinStack {

    private Stack<int[]> stk;

    public MinStack() {
        stk = new Stack<int[]>();
    }
    
    public void push(int val) {
         if(stk.isEmpty())
         {
            stk.push(new int[] {val,val} );
         }
         else
         {
            stk.push(new int[]{val,Math.min(val,stk.peek()[1])});
         }
    }
    
    public void pop() {
       stk.pop();
    }
    
    public int top() {
       return stk.peek()[0];
    }
    
    public int getMin() {
        return stk.peek()[1];
    }
}
}
