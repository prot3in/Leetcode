/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists.Length == 0)
            return  null;
        if(lists.Length == 1)
            return lists[0];
        if(lists.Length == 2)
            return MergeTwoLists(lists[0],lists[1]);
        
        int mid = lists.Length/2;
        ListNode[] l1 = new ListNode[mid],l2 = new ListNode[lists.Length -  mid];
        for(int i = 0; i < mid; i++){
            l1[i] = lists[i];
        }
        for(int i = mid;i<lists.Length;i++){
            l2[i-mid]=lists[i];
        }
        return MergeTwoLists(MergeKLists(l1),MergeKLists(l2));
    }

    

    public ListNode MergeTwoLists(ListNode l1,ListNode l2){
         ListNode l3,p;
        l3 = p = new ListNode();
        while(l1!=null && l2!=null){
            if(l1.val<l2.val){
                p.next=l1;
                p = p.next;
                l1=l1.next;
            }
            else{
                p.next = l2;
                p = p.next;
                l2=l2.next;
            }
        }
        if(l1==null){
            while(l2!=null){
                 p.next = l2;
                 p  = p.next;
                 l2 = l2.next;
            }
        }
        if(l2==null){
            while(l1!=null){
                 p.next = l1;
                 l1 = l1.next;
                 p  = p.next;
            }
        }
        return l3.next;
    }
}
