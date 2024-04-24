using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Linked_List
{
    internal class Remove_Nth_Node_From_End_of_List
    {
        public Node RemoveNthFromEnd(Node head, int n)
        {
            Node temp = head;
            int len = 0;
            while (temp != null)
            {
                len++;
                temp = temp.next;
            }
            if (n == 0)
            {
                head = head.next;
            }
            else if (len == n)
            {
                return head.next;
            }
            else
            {
                Node prev = null;
                Node curr = head;
                int dif = len - n;
                for (int i = 0; i < dif; i++)
                {
                    prev = curr;
                    curr = curr.next;
                }
                prev.next = curr.next;

            }
            return head;
        }
    }
}
