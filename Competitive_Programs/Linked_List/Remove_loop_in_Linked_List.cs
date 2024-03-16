using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Linked_List
{

    abstract class Card{

       public  abstract double GetSelPrice();
    }

    internal class Node
    {
        

        public int data;
        public Node next = null;

        public Node(int data) { 
            this.data = data;
        }
    }
    internal class Remove_loop_in_Linked_List
    {
        public static void removeLoop(Node head)
        {
            // code here
            // remove the loop without losing any nodes

            

            if (head == null)
                return;

            Node slow = head;
            Node fast = head;

            int f = 0;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (fast == slow)
                {
                    f = 1;
                    break;
                }
            }

            if (fast == null || fast.next == null)
                return;

            slow = head;
            while (fast != slow)
            {
                fast = fast.next;
                slow = slow.next;
            }

            while (slow != fast.next)
            {
                fast = fast.next;
            }
            fast.next = null;
            //             HashSet<Node> visited = new HashSet<Node>();
            // 			while (head == null)
            // 			{
            // 				if (visited.contains(head))
            // 					head.next = null;

            // 				visited.add(head);

            // 				head = head.next;
            // 			}

        }
    }
}
