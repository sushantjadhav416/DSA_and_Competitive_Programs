using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Binary_tree
{
    internal class Invert_Binary_Tree
    {
        public Node invertTree(Node root) 
       {
            if(root==null)
                return null;

           Node left  =  root.left;
           Node right =  root.right;


           root.left  = invertTree(right);
           root.right = invertTree(left);

           return root;
        }
    }
}
