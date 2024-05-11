using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Linked_List
{
    internal class Merge_Sort_on_Doubly_Linked_List
    {
        static Node Split(Node head)
        {
            Node fast = head;
            Node slow = head;

            while (fast.next != null && fast.next.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            Node curr = slow.next;
            slow.next = null;
            return curr;
        }

        static Node marge(Node first, Node second)
        {
            if (first == null)
            {
                return second;
            }

            if (second == null)
            {
                return first;
            }

            if (first.data < second.data)
            {
                first.next = marge(first.next, second);
                first.next.prev = first;
                first.prev = null;
                return first;
            }
            else
            {
                second.next = marge(first, second.next);
                second.next.prev = second;
                second.prev = null;
                return second;
            }
        }
        static Node sortDoubly(Node head)
        {
            // add your code here

            if (head == null || head.next == null)
            {
                return head;
            }
            Node second = Split(head);


            head = sortDoubly(head);
            second = sortDoubly(second);


            return marge(head, second);
        }
    }
}
