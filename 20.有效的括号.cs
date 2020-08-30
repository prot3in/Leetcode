/*
利用栈的括号匹配问题
*/
public class Solution {
    public bool IsValid(string s) {
         Stack<char> st= new Stack<char>();
            for(int i = 0; i < s.Length; i++)
            {
                if(st.Count == 0 || !is_match(st.Peek(),s[i]))
                {
                    st.Push(s[i]);
                }
                else
                {
                    st.Pop();
                }
            }
            return st.Count == 0;
    }
     Boolean is_match(char a,char b)
        {
            return (a=='(' && b==')') || (a == '[' && b == ']') || (a == '{' && b == '}');
        }
}
