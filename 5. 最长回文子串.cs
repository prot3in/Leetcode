/*
给定一个字符串 s，找到 s 中最长的回文子串。你可以假设 s 的最大长度为 1000。

示例 1：

输入: "babad"
输出: "bab"
注意: "aba" 也是一个有效答案。
示例 2：

输入: "cbbd"
输出: "bb"
*/

public class Solution
        {
            //动态规划
            public string LongestPalindrome(string s)
            {
                string r = "";
                bool[,] P = new bool[s.Length, s.Length];

                for (int len = 1; len <= s.Length; len++)
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        //len = 1, len = 2,
                        int j = i + len - 1;
                        if (j >= s.Length) break;
                        if (len == 1)
                        {
                            P[i, j] = true;
                        }
                        else if (len == 2 && s[i] == s[j])
                        {
                            P[i, j] = true;
                        }
                        else if (P[i + 1, j - 1] && s[i] == s[j])
                        {
                            P[i, j] = true;
                        }
                        else { P[i, j] = false; }

                        if (P[i, j] && len > r.Length)
                        {
                            r = s.Substring(i, len);
                        }

                    }


                }
                return r;
            }



            //中心扩展法
            public string LongestPalindrome(string s)
            {
                string result = "";
                int n = s.Length * 2 - 1;
                for(int i = 0; i < n; i++)
                {
                    int m = i / 2;
                    int p, q;
                    if (i % 2 == 0)
                    {
                        p = m - 1;
                        q = m + 1;                       
                    }
                    else
                    {
                        p = m;
                        q = m + 1;
                    }
                    while ((p >= 0 && q < s.Length) && s[p] == s[q])
                    {
                        p--; q++;
                    }
                    int len = q - p - 1;
                    if (len > result.Length)
                    {
                        result = s.Substring(p + 1, len);
                    }
                        

                }


                return result;
            }
            
            
            //马拉车法
            public string LongestPalindrome(string s)
            {
                string result = "";
           
                return result;
            }
        }
