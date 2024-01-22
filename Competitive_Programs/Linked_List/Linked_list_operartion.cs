using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.Linked_List
{
	public class Node
	{
		public int data;
		public Node next;

		public Node(int d)
		{
			data = d;
			next = null;
		}

	}


	public class linkedlist
	{
		public Node head;

		//10->12->15->17

		public void AddNode(Node node)
		{
			if (head == null)
			{
				head = node;
			}
			else
			{
				Node temp = head;
				while (temp.next != null)
				{
					temp = temp.next;
				}
				temp.next = node;
			}
		}
		void removeDuplicates()
		{
			/*Another reference to head*/
			Node curr = head;

			/* Traverse list till the last node */
			while (curr != null)
			{
				Node temp = curr;
				/*Compare current node with the next node and
				keep on deleting them until it matches the
				current node data */
				while (temp != null && temp.data == curr.data)
				{
					temp = temp.next;
				}
				/*Set current node next to the next different
				element denoted by temp*/
				curr.next = temp;
				curr = curr.next;
			}
		}

		void remove_duplicates(Node head)
		{
			Node ptr1 = null, ptr2 = null, dup = null;
			ptr1 = head;

			/* Pick elements one by one */
			while (ptr1 != null && ptr1.next != null)
			{
				ptr2 = ptr1;

				/* Compare the picked element with rest
					of the elements */
				while (ptr2.next != null)
				{

					/* If duplicate then delete it */
					if (ptr1.data == ptr2.next.data)
					{

						/* sequence of steps is important here
						 */
						ptr2.next = ptr2.next.next;
						
					}
					else /* This is tricky */
					{
						ptr2 = ptr2.next;
					}
				}
				ptr1 = ptr1.next;
			}
		}

		public void push(int  d)
		{
			Node new_data = new Node(d);

			new_data.next = head;

			head = new_data;
		}

		public static Node addOne(Node head)
		{
			//code here.
			Node curr = head;
			int len = 0;
			string s = "";

			while (curr != null)
			{
				s = s + curr.data;
				curr = curr.next;
			}

			int n1 = Convert.ToInt32(s);

			n1 = n1 + 1;

			Node same = head;

			while (n1 != 0) ;
			{
				int rem = n1 % 10;
				same.data = rem;
				same = same.next;
				n1 = n1 / 10;
			}

			return head;

		}

		public static int findFirstNode(Node head)
		{

			//code here

			Node temp = new Node(head.data);

			while (head != null)
			{

				if (head.next == null)
				{
					return -1;
				}

				if (head.next == temp)
				{
					break;
				}

				Node nex = head.next;

				head.next = temp;

				head = nex;
			}
			return head.data;

		}


		//Linked list traversal
		public void PrintList(Node head)
		{
			Node curr = head;
			while(curr != null){
				Console.Write("->"+curr.data);
				curr = curr.next;
			}
		}

		//10->12->15->17

		//17->15->12->10

		//Likedlist reverse traversal
		public void reverselist()
		{
			Node prev = null, next = null, cur = head;
			while(cur != null)
			{
				next = cur.next;
				cur.next = prev;
				prev = cur;
				cur = next;
			}
			head = prev;
		}

		public void  insert(int data, int pos) 
		{ 
		    Node Toadd = new Node(data);

			if (pos == 0)
			{
				Toadd.next = head;
				head = Toadd;
			}

			Node prev = head;

            for(int i = 0; i < pos-1; i++) 
            {
				prev = prev.next;	
            }

			Toadd.next = prev.next;
			prev.next = Toadd;
		}

		public void Deletion(int pos)
		{
			if (pos == 0)
			{
				head = head.next;
			}

			Node prec = head;

			for(int i = 0; i < pos - 1; i++)
			{
				prec = prec.next;
			}
			prec.next = prec.next.next;

		}

		public bool Detect_loop(Node h)
		{
			HashSet<Node> visited = new HashSet<Node>();

			while(h == null){
				if (visited.Contains(h))
					return true;

				visited.Add(h);

				h = h.next;
			}
			return false;
		}

        public bool Detect_loop_BTC(Node h)
        {
			Node first = head;
			Node second = head;

            while (first != null && second != null)
            {
				first  = first.next.next;
				second = second.next;
				if (first == second)
					return true;
            }

			return false;
        }

        public int Find_length_off_the_loop_(Node h)
        {
            Node first = head;
            Node second = head;
			int length = 0;
            while (first != null && first.next != null)
            {
                first = first.next.next;
                second = second.next;
                if (first == second)
				{
					Node temp = second;
					do
					{
						temp = temp.next;
						length++;
					}
					while(temp != second);
				}   
            }
            return length;
        }

        public bool Delet_loop(Node h)
		{
			HashSet<Node> visited = new HashSet<Node>();

			while (h == null)
			{
				if (visited.Contains(h))
					h.next = h.next.next;

				visited.Add(h);

				h = h.next;
			}
			return false;
		}

	}
	internal class Linked_list_operartion
	{
		public static void Main(string[] args)
		{
			linkedlist ls1 = new linkedlist();

			ls1.AddNode(new Node(1));
			ls1.AddNode(new Node(5));
			ls1.AddNode(new Node(2));
			

			linkedlist.addOne(ls1.head);


		}

	}
}
