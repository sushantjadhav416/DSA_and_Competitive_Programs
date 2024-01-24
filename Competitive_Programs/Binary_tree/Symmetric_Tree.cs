using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Binary_tree
{

    public class Node
    {
        internal Node right, left;
        internal int data;
        public Node(int data)
        {
            this.data = data;
        }
    }
    internal class Symmetric_Tree
    {

        public bool isSymmetric(Node root)
        {
            return isSymmetric(root, root);
        }
        public bool isSymmetric(Node p, Node q)
        {
            if (p == null || q == null)
                return p == q;

            return (p.data == q.data) && isSymmetric(p.left, q.right) && isSymmetric(p.right, q.left);
        }
    }
}
