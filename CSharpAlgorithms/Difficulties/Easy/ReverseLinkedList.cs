using System.Collections.Generic;
using CSharpAlgorithms.Global;

namespace CSharpAlgorithms.Difficulties.Easy
{
    public class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            List<ListNode> nodes = new List<ListNode>();
            ListNode dummy = new ListNode();
            ListNode curr = head;
            while (curr != null)
            {
                ListNode prev = curr;
                nodes.Add(prev);
                curr = curr.next;
                prev.next = null;
            }
            ListNode result = dummy;
            nodes.Reverse();
            foreach (ListNode node in nodes)
            {
                result.next = node;
                result = result.next;
            }
            return dummy.next;
        }
    }
}