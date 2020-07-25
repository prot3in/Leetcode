/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
 //只写了递归的
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        return recursion(l1,l2,0);
    }
    public ListNode recursion(ListNode l1, ListNode l2, int flag) {
        if(l1==null && l2==null &&  flag==0) return null;
        ListNode list3 = new ListNode();
        int c = flag;
        if(l1!=null){
            c+=l1.val;
            l1 = l1.next;
        }
        if(l2!=null){
            c+=l2.val;
            l2 = l2.next;
        }
        list3.val = c%10;
        list3.next = recursion( l1, l2, c/10 );
        return list3;
    }
}
