using CSharpAlgorithms.Global;

namespace CSharpAlgorithms.Difficulties.Easy
{
    public class ReverseLinkedListRecursive
    {
        ListNode res;
        public ListNode ReverseList(ListNode head)
        {
            this.TraverseList(head);
            return this.res;
        }
    
        public void TraverseList(ListNode curr, ListNode prev=null){
            if (curr == null){
                this.res = prev;
                return;
            }
            this.TraverseList(curr.next, curr);
            curr.next = prev;
        }
    }
}