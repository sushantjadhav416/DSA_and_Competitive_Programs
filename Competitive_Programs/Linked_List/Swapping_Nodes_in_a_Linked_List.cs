using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Linked_List
{
    internal class Swapping_Nodes_in_a_Linked_List
    {
        public int GetLength(Node head)
        {
            int len = 0;
            Node lenN = head;
            while (lenN != null)
            {
                len++;
                lenN = lenN.next;
            }
            return len;
        }

        public void Swap(Node N1, Node N2)
        {
            Node temp = new Node(0);
            temp.data= N1.data;
            N1.data = N2.data;
            N2.data = temp.data;
        }

        public Node swapNodes(Node head, int k)
        {
            Node start = head;
            Node end = head;

            int length = GetLength(head);
            for (int i = 0; i < k - 1; i++)
            {
                start = start.next;
            }
            int dif = length - k;

            for (int i = 0; i < dif; i++)
            {
                end = end.next;
            }

            Swap(start, end);

            return head;
        }
    }
}
