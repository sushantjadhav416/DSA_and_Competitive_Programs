using Competitive_Programs.Binary_tree;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Linked_List
{
	internal class Merging_To_LinkedList
	{
		public static Node soetedlistmaerge(Node list1,Node list2)
		{
			Node newnode = new Node(0);
			Node curr = newnode;

			while (list1 != null && list2 != null)
			{
				if (list1.data< list2.data)
				{
					curr.next = list1;
					list1 = list1.next;
				}
				else
				{
					curr.next = list2;
					list2 = list2.next;
				}
				curr = curr.next;
			}

			if (list1 == null)
			{
				curr.next = list2;
			}

			if (list2 == null)
			{
				curr.next = list1;
			}
			return newnode.next;
		}
		public static void m_Main(string[] args)
		{

		}
	}
}
