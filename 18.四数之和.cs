/*
和三数之和类似，只是再多一层循环；用双指针。
*/
public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        IList<IList<int>> res = new List<IList<int>>();
            
            Array.Sort(nums);
            if (nums.Length < 4) return res;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;//去重
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1]) continue;//去重
                    int L = j + 1;
                    int R = nums.Length - 1;
                    while (L < R)
                    {
                        int sum = nums[i] + nums[j] + nums[L] + nums[R];
                        if (sum == target)
                        {
                            res.Add(new List<int> { nums[i], nums[j], nums[L], nums[R] });
                            while (L < R && nums[L] == nums[L + 1]) L++;//去重
                            while (L < R && nums[R] == nums[R - 1]) R--;//去重
                            L++;
                            R--;
                        }
                        else if (sum > target) R--;
                        else if (sum < target) L++;
                    }
                }
            }

            

            return res;
    }
}
