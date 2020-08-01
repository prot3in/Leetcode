/*给你一个包含 n 个整数的数组 nums，判断 nums 中是否存在三个元素 a，b，c ，使得 *a + b + c = 0 ？请你找出所有满足条件且不重复的三元组。

注意：答案中不可以包含重复的三元组。

 

示例：

给定数组 nums = [-1, 0, 1, 2, -1, -4]，

满足要求的三元组集合为：
[
  [-1, 0, 1],
  [-1, -1, 2]
]
*/

//哈希表  确定x,y 在哈希表中寻找0-X-Y
public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
             IList<IList<int>> ls = new List<IList<int>>();
            Array.Sort(nums);
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]] = i;
                }
                else
                {
                    dic.Add(nums[i], i);
                }
            }

            for(int i = 0; i < nums.Length; i++)
            {
                if (i- 1>=0 && nums[i] == nums[i - 1]) continue;
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if (j>i+1 && nums[j] == nums[j-1]) continue;
                    int k = 0 - nums[i] - nums[j];
                    if (dic.ContainsKey(k) && dic[k]>j )
                    {
                        ls.Add( new List<int>() { nums[i], nums[j], 0 - nums[i] - nums[j] });
                    }
                }
            }
            

            return ls;

    }
}
