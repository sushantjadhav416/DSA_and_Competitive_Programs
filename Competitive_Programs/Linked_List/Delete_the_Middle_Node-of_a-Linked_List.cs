using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Linked_List
{
    internal class Delete_the_Middle_Node_of_a_Linked_List
    {
        public int getLength(Node head)
        {
            int len = 0;
            Node MyN = head;
            while (MyN != null)
            {
                len++;
                MyN = MyN.next;
            }
            return len;
        }

        public Node deleteMiddle(Node head)
        {
            int length = getLength(head);

            if (length == 1)
                return null;

            Node curr = head;
            for (int i = 0; i < ((length / 2) - 1); i++)
            {
                curr = curr.next;
            }

            curr.next = curr.next.next;

            return head;

        }
    }
}
