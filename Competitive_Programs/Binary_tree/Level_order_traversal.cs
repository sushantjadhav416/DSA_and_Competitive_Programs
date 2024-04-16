using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Binary_tree
{
	
	internal class Level_order_traversal
    {
        
        public static Node Tree_Create()
        {
            Node root = null;

            Console.WriteLine("Enter the data:");
            int data = Convert.ToInt32(Console.ReadLine());

            if (data == -1) return null ;

            root = new Node(data);

            Console.WriteLine("Enter the left of:{0}",data);
            root.left=Tree_Create();
			Console.WriteLine("Enter the Right:{0}",data);
			root.right = Tree_Create();


            return root ;
		}

        public static int Tree_hi(Node root)
        {
            if(root == null) return 0 ;

            return Math.Max(Tree_hi(root.left) , Tree_hi(root.right)) + 1;
        }
        //level= Hight of a tree
        public static void   current_Level_order(Node root, int level)
        {
            if (root == null) 
                return;

            if (level == 1)
            {
                Console.Write(root.data + " ");
            }
            else if(level > 1)
            {
                current_Level_order(root.left, level - 1);
                current_Level_order(root.right, level - 1);
            }

        }

        public static void level_order_rec(Node root,int level)
        {
            int h = level;

            for(int i = 1; i <= h; i++)
            {
                current_Level_order(root,i);
            }

        }

        public static void level_order_quae(Node root)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);

            while(q.Count!=0)
            {

                Node tempnode = q.Dequeue();

                Console.Write(tempnode.data+" ");

                if (tempnode.left!=null)
                {
                   q.Enqueue(tempnode.left);
                }

                if (tempnode.right!=null) 
                { 
                   q.Enqueue(tempnode.right); 
                }

            }

        }

        public static Node create_Node(int val)
        {

            Node newnode  = new Node(val);
            newnode.right = null;
            newnode.left = null;

            return newnode;

        }

        public static Node Tree_merror(Node root)
        {
            if (root == null)
                 return null;

            Node mirror = create_Node(root.data);
            mirror.left = Tree_merror(root.left);
            mirror.right = Tree_merror(root.right);

            return mirror;

        }

        public static void inoreder_itertive_way(Node root)
        {
            if(root==null)
                return ;

            Stack<Node> st = new Stack<Node>();
            Node curr = root;

            while(curr!=null && st.Count()==0)
            {

                while(curr != null)
                {
                    st.Push(curr);
                    curr = curr.left;
                }

                curr = st.Pop();
                Console.Write(curr.data+" ");
                curr = curr.right;
            }
        }


        public static void lv_Main(string[] args)
        {
            Node root = Tree_Create() ;
            
            Console.Write("The level order traversel:");
            level_order_rec(root, Tree_hi(root));

            Node merror = Tree_merror(root);
            Console.WriteLine();
			Console.Write("The level order traversel of merror tree:");
			inoreder_itertive_way(merror);



		}
    }
}
