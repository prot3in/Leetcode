/*
给定一个包括 n 个整数的数组 nums 和 一个目标值 target。找出 nums 中的三个整数，使得它们的和与 target 最接近。返回这三个数的和。假定每组输入只存在唯一答案。

示例：
输入：nums = [-1,2,1,-4], target = 1
输出：2
解释：与 target 最接近的和是 2 (-1 + 2 + 1 = 2) .
*/

//第一次自己独立做出来的双指针。
public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        int min = int.MaxValue;
        int sum = 0;
        Array.Sort(nums);
        for(int i = 0; i<nums.Length-2;i++){
            int x = i+1, y = nums.Length-1;
            while(x!=y){
                int d = Math.Abs(nums[i]+nums[x]+nums[y]-target);
                if(d < min) {min = d;sum = nums[i]+nums[x]+nums[y];}
                if(nums[i]+nums[x]+nums[y]-target>0) y--;
                else x++;  
            }
        }
        return sum;
    }
}
