public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length==0) return 0;
          int l = 0,s = 1;
          while(s<nums.Length){
              if(nums[l] != nums[s]){
                  l++;
                  nums[l]= nums[s];
              }
              s++;
          }  
          return l+1;
    }
}
