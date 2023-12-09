using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Binary_tree
{
	public class Node
	{
		internal Node right, left;
		internal int data;
		public Node(int data) {
			this.data = data;
		}	
	}
	internal class Binary_tree
	{
	   public static Node createTree()
		{
			Node root = null;

			Console.WriteLine("Enter data: ");
			int data = Convert.ToInt32(Console.ReadLine());

			if (data == -1) return null;

			root = new Node(data);

			Console.WriteLine("Enter left for data:{0}",data);
			root.left = createTree();

			Console.WriteLine("Enter right for  data:{0}", data);
			root.right = createTree();

			return root;
		}
		static int idx = -1;
		public static Node Buildtree(int[] nodes)
		{
			idx++;

			if (nodes[idx]==-1)
			{
				return null;
			}


			Node root = new Node(nodes[idx]);

			root.left = Buildtree(nodes);
			root.right = Buildtree(nodes);

            return root;
		}

		public static  List<int> inorder(Node root)
		{
			List<int> ls = new List<int>();
		
			if (root == null) 
				return ls;
			
				inorder(root.left);
				ls.Add(root.data);
				inorder(root.right);

			return ls;
		}
		public static void preorder(Node root)
		{
			if (root == null) return;

			Console.Write(root.data+" ");
			preorder(root.left);
			preorder(root.right);

		}
		public static  void postorder(Node root)
		{

			if (root == null) return;

			postorder(root.left);
		    postorder(root.right);
			Console.Write(root.data+" ");

		}

		public static int Tree_Hight(Node root)
		{
			if (root == null)
				return 0;

			return Math.Max(Tree_Hight(root.left),Tree_Hight(root.right))+1;

		}


		public static int  Tree_size(Node root)
		{
			if (root == null)
				return 0;

			return Tree_size(root.left)+Tree_size(root.right) + 1;
		}

		public static int Tree_Maximum(Node root)
		{
			if(root == null) 
				return int.MinValue;

			return Math.Max(root.data,Math.Max(Tree_Maximum(root.left),Tree_Maximum(root.right)));
		}

		public static int Tree_Minimum(Node root)
		{
			if (root == null)
				return int.MaxValue;

			return Math.Min(root.data, Math.Min(Tree_Minimum(root.left),Tree_Minimum(root.right)));
		}

		public static void bn_Main(string[] args)
		{
			Binary_tree tree = new Binary_tree();
			//Node root = createTree();

			//Console.WriteLine("The inorder:");
			//var ls = inorder(root);
			//foreach(var l in ls)
			//{
			//	Console.WriteLine(l);
			//}
			//Console.WriteLine();
			//Console.WriteLine("The preorder:");
			//preorder(root);
			//Console.WriteLine();
			//Console.WriteLine("The postorder:");
			//postorder(root);
			//Console.WriteLine();
			//Console.WriteLine("Tree Hight:");
			//Console.WriteLine(Tree_Hight(root));
			//Console.WriteLine("Tree Size:");
			//Console.WriteLine(Tree_size(root));
			//Console.WriteLine("Tree maximum element:");
			//Console.WriteLine(Tree_Maximum(root));
			//Console.WriteLine("Tree minimum element:");
			//Console.WriteLine(Tree_Minimum(root));

			int[] nodes = { 3, 2, 4, 5, -7, -4, 1, 4, 5, 6, 7, 8 };
			Node root = Buildtree(nodes);

			inorder(root);

		}


	}
}
