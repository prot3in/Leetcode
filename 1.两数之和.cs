/*
给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。
你可以假设每种输入只会对应一个答案。但是，数组中同一个元素不能使用两遍。

示例:

给定 nums = [2, 7, 11, 15], target = 9

因为 nums[0] + nums[1] = 2 + 7 = 9
所以返回 [0, 1]

*/
public class Solution 
{
    public int[] TwoSum(int[] nums, int target)
    {
       //暴力法
       for(int i = 0 ; i < nums.Length ; i++)
       {
           for (int j= i + 1 ; j < nums.Length ; j++)
           {
               if(nums[i]+nums[j]==target)
                    return new int[]{i,j};
           }
       }
       return new int[]{0,0};
        
       //二次哈希表法
       Dictionary<int, int> dic= new Dictionary<int, int>();
       for (int i = 0; i < nums.Length; i++)
       {
           if (dic.ContainsKey(nums[i]) )
           {
               if ( nums[i] * 2 == target )
                   return new int[] { dic[nums[i]],i };
           }
           else
           {
               dic.Add(nums[i], i);
           }

       }
       for (int i = 0; i < nums.Length; i++)
       {
            if (dic.ContainsKey(target - nums[i]) && i != dic[target - nums[i]])
            {
                return new int[] {  dic[target - nums[i]]  , i };
            }
       }
       return new int[] { 1, 1 };

        //一次哈希表
       Dictionary<int, int> dic = new Dictionary<int, int>();
       for (int i = 0; i < nums.Length; i++)
       {
                
            if (dic.ContainsKey(target - nums[i]))
            {
                 return new int[] { i, dic[target - nums[i]] };
            }
            else
            {
                 if(!dic.ContainsKey(nums[i]))
                      dic.Add(nums[i], i);
            }
                
        }
        return new int[] {1,1};

    }
}
