using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.Linked_List
{
    internal class Delete_without_head_pointer
    {
        void deleteNode(Node del_node)
        {
            // Your code here

            if (del_node == null)
            {
                return;
            }
            else
            {
                if (del_node.next == null)
                {

                    return;
                }
            }

            del_node.data = del_node.next.data;

            del_node.next = del_node.next.next;


        }
    }
}
