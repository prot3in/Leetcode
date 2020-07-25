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
