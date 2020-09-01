/*
数字 n 代表生成括号的对数，请你设计一个函数，用于能够生成所有可能的并且 有效的 括号组合。
*/

public class Solution {
    IList<string> result = new List<string>();
    public IList<string> GenerateParenthesis(int n) {
        //trace("",0,0,n);
        trace("",n,n);
        return result;
    }
//l,r表示剩余的左右括号数
    public void trace(string str, int l,int r){
        if(l==r && l==0){
            result.Add(str);
            return;
        }
        if(l==r){
            trace(str+'(',l-1,r);
        }
        else if(l<r){
            if(l>0)
                trace(str+'(',l-1,r);
            trace(str+')',l,r-1);
        }
    }

//l,r表示已有的括号数
    public void trace(string str,int l,int r,int n){
        if(l==r && l==n){
            result.Add(str);
            return;
        }
        if(l<n){
            trace(str+'(',l+1,r,n);
        }
        if(r<l){
            trace(str+')',l,r+1,n);
        }
    }
}
