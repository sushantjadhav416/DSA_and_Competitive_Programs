using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Binary_tree
{
    internal class Reverse_Level_Order_Traversal
    {
        public ArrayList<Integer> reverseLevelOrder(Node node) 
       {
          // code here
        
        ArrayList<Integer> Ls = new ArrayList<Integer>();
        
        if(node == null)
        {
            return Ls;
        }
        
        Stack<Integer> stk = new Stack<Integer>();
        
        Queue<Node> q = new LinkedList<Node>();
        
        q.add(node);
        
        while(!q.isEmpty())
        {
            Node tempNode = q.poll();
            
            stk.push(tempNode.data);
            
            if(tempNode.right!=null)
            {
               q.add(tempNode.right);
            }
            
            if(tempNode.left!=null)
            {
               q.add(tempNode.left);
            }
            
        }
        
        
        while(!stk.isEmpty())
        {
            Ls.add(stk.pop());
        }
        
           return Ls;
        }
    }
}
