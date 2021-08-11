using CSharpAlgorithms.Global;

namespace CSharpAlgorithms.Difficulties.Easy
{
    public class RemoveElementsClass
    {
        public ListNode RemoveElements(ListNode head, int val) {
            ListNode dummyHead = new ListNode();
            ListNode dummyNode = dummyHead;
        
            ListNode curr = head;
            while (curr != null){
                if (curr.val != val){
                    dummyNode.next = curr;
                    dummyNode = dummyNode.next;
                    curr = curr.next;
                }
                else{
                    curr = curr.next;
                    dummyNode.next = null;
                }
            }
            return dummyHead.next;
        }
    }
}