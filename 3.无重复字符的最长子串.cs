//sliding_window

/*
给定一个字符串，请你找出其中不含有重复字符的 最长子串 的长度。

示例 1:

输入: "abcabcbb"
输出: 3 
解释: 因为无重复字符的最长子串是 "abc"，所以其长度为 3。
示例 2:

输入: "bbbbb"
输出: 1
解释: 因为无重复字符的最长子串是 "b"，所以其长度为 1。
示例 3:

输入: "pwwkew"
输出: 3
解释: 因为无重复字符的最长子串是 "wke"，所以其长度为 3。

*/
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int maxLength = 0;
            List<char> ls = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
               
                if (ls.Contains(s[i]))
                {
                    
                    ls.RemoveRange(0, ls.IndexOf(s[i]) + 1);
                }
                ls.Add(s[i]);
                if ( ls.Count() > maxLength)
                    maxLength = ls.Count();     
            }

            return maxLength;
    }
}
