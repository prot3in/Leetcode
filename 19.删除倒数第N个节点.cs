/*
给定一个链表，删除链表的倒数第 n 个节点，并且返回链表的头结点。

示例：

给定一个链表: 1->2->3->4->5, 和 n = 2.

当删除了倒数第二个节点后，链表变为 1->2->3->5.
说明：

给定的 n 保证是有效的。

进阶：

你能尝试使用一趟扫描实现吗
*/

public class Solution {
    //一个指针两次遍历
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode p = head;
        if(p.next == null) return null;
            while (true)
            {
                int s = n;
                ListNode r = p;
                while (s != 0)
                {
                    r = r.next; 
                    s--;
                }
                if(r==null) return head.next;
                if (r.next == null) 
                {
                    p.next = p.next.next;
                    return head;
                }
                p=p.next;
            }  
    }
    //两个指针，一次遍历
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode res = new ListNode(0); res.next = head;
        ListNode p = res;
        ListNode r = res;
        while(n!=0){
            p = p.next;
            n--;
        }
        while(p.next!=null) {
            p=p.next;
            r=r.next;
        }
        r.next = r.next.next;
        return res.next;
            
            
    }
}
