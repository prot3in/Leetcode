例如： 给定 1->2->3->4, 你应该返回 2->1->4->3.


/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
 // 构造 pre->p->s;
public class Solution {
    public ListNode SwapPairs(ListNode head) {
            if(head==null || head.next ==null) return head;
            ListNode r = head.next,p = head, s = head.next;
            ListNode pre = new ListNode(0);
            pre.next = head; 
           
            while(p != null && s!= null){
               
               p.next = s.next;
               s.next = p;
               pre.next = s;

               pre = p;
               p = p.next;
               if(p!=null)
                  s = p.next;
               
            }
            return r;
    }
}
