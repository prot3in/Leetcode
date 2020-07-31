/*编写一个函数来查找字符串数组中的最长公共前缀。

如果不存在公共前缀，返回空字符串 ""。

示例 1:

输入: ["flower","flow","flight"]
输出: "fl"
示例 2:

输入: ["dog","racecar","car"]
输出: ""
解释: 输入不存在公共前缀。\
*/

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length==0) return "";
        int s_min = strs.Select(s => s.Length).Min();
        for(int i = 1 ;i<=s_min;i++){
            for(int j = 0;j<strs.Length;j++){
                if(!strs[j].StartsWith(strs[0].Substring(0,i)))
                    return strs[0].Substring(0,i-1);
            }
        }
         return strs[0].Substring(0, s_min);
    }
}
