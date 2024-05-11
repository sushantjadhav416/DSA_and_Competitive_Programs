using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Binary_tree
{
    internal class Reverse_Level_Order_Traversal
    {
        public List<int> reverseLevelOrder(Node node) 
       {
          // code here
        
        List<int> Ls = new List<int>();
        
        if(node == null)
        {
            return Ls;
        }
        
        Stack<int> stk = new Stack<int>();
        
        Queue<Node> q = new Queue<Node>();
        
        q.Enqueue(node);
        
        while(q.Count()!=0)
        {
            Node tempNode = q.Peek();
            
            stk.Push(tempNode.data);
            
            if(tempNode.right!=null)
            {
               q.Enqueue(tempNode.right);
            }
            
            if(tempNode.left!=null)
            {
               q.Enqueue(tempNode.left);
            }
            
        }
        
        
        while(stk.Count()!=0)
        {
            Ls.Add(stk.Pop());
        }
        
           return Ls;
        }
    }
}
