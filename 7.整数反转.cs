/*
给出一个 32 位的有符号整数，你需要将这个整数中每位上的数字进行反转。

示例 1:

输入: 123
输出: 321
 示例 2:

输入: -123
输出: -321
示例 3:

输入: 120
输出: 21
注意:

假设我们的环境只能存储得下 32 位的有符号整数，则其数值范围为 [−231,  231 − 1]。请根据这个假设，如果反转后整数溢出那么就返回 0。
*/
public class Solution {
    public int Reverse(int x) {
        string s = x > 0 ? x.ToString() : (x * (-1)).ToString();
        int result;
        if (int.TryParse(new string(s.ToCharArray().Reverse<char>().ToArray<char>()), out result))
           return x > 0 ? result : result * (-1);
        else
           return 0;
            //long l = 0;
            //while (x != 0)
            //{
            //    l = l * 10 + x % 10;
            //    x = x / 10;
            //}
            //if (l > int.MaxValue || l < int.MinValue)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return int.Parse(l.ToString());
            //}
    }
}
