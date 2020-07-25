/*
给出两个 非空 的链表用来表示两个非负的整数。其中，它们各自的位数是按照 逆序 的方式存储的，并且它们的每个节点只能存储 一位 数字。
如果，我们将这两个数相加起来，则会返回一个新的链表来表示它们的和。
您可以假设除了数字 0 之外，这两个数都不会以 0 开头。

示例：

输入：(2 -> 4 -> 3) + (5 -> 6 -> 4)
输出：7 -> 0 -> 8
原因：342 + 465 = 807
*/
//迭代
struct ListNode* addTwoNumbers(struct ListNode* l1, struct ListNode* l2){
    struct ListNode * p ,*l3;
    l3 = (struct ListNode*)malloc(sizeof(struct ListNode));
    p = l3;
    int flag = 0;
    while (l1 && l2) {
        p->next = (struct ListNode*)malloc(sizeof(struct ListNode));
        p = p -> next;
        p->val = l1->val + l2->val + flag;
        flag = 0;
        if (p->val >= 10) {
            flag = 1;
            p->val = p->val % 10;
        }
        l2 = l2->next;
        l1 = l1->next;
       
    }
    if (l2) {
        while (l2) {
            p->next = (struct ListNode*)malloc(sizeof(struct ListNode));
            p = p->next;
            p->val = l2->val + flag;
            if(p->val>=10){
                p->val = p->val%10;
                flag = 1;
            }
            else{
                flag = 0;
            }
            l2 = l2->next;
        }
    }
    else if (l1) {
        while (l1) {
            p->next = (struct ListNode*)malloc(sizeof(struct ListNode));
            p = p->next;
            p->val = l1->val + flag;
              if(p->val>=10){
                p->val = p->val%10;
                flag = 1;
            }
            else{
                flag = 0;
            }
            l1 = l1->next;
        }   
    }
    if(flag){
            p->next = (struct ListNode*)malloc(sizeof(struct ListNode));
            p = p->next;
            p->val = flag;         
    }
      p->next = NULL;
    return l3->next;

}



//递归
struct ListNode* recursion(struct ListNode* l1, struct ListNode* l2,int flag){
    if(!l1 && !l2 && !flag) return NULL;
    struct ListNode *l3;
    l3 = (struct ListNode*)malloc(sizeof(struct ListNode));
    int c = flag;
    l1 = l1? ( c += l1->val, l1->next ) : l1;
    l2 = l2? ( c += l2->val, l2->next ) : l2; 
    l3->val = c%10;
    l3->next = recursion( l1, l2, c/10 );
    return l3;
}
struct ListNode* addTwoNumbers(struct ListNode* l1, struct ListNode* l2){
    return recursion(l1,l2,0);
}
