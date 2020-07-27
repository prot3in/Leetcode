public class Solution {
    public bool IsPalindrome(int x) {
        int y = 0;
        if(x<0) return false;
        int n = x;
        while(n!=0){
            y=y*10+n%10;
            n = n/10;
        }
        if(x==y) return true;
        else return false;
        
    }
}
