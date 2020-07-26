/*
给定两个大小为 m 和 n 的正序（从小到大）数组 nums1 和 nums2。
请你找出这两个正序数组的中位数，并且要求算法的时间复杂度为 O(log(m + n))。
你可以假设 nums1 和 nums2 不会同时为空。

示例 1:

nums1 = [1, 3]
nums2 = [2]

则中位数是 2.0
示例 2:

nums1 = [1, 2]
nums2 = [3, 4]

则中位数是 (2 + 3)/2 = 2.5
*/

//寻找第k小数
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int len = (nums1.Length + nums2.Length);
            int k = len / 2 + 1;
            if (len % 2 == 0)
                return (GetKMin(nums1, 0, nums1.Length - 1, nums2, 0, nums2.Length - 1, k - 1) + GetKMin(nums1, 0, nums1.Length - 1, nums2, 0, nums2.Length - 1, k)) / 2.0d;
            else
                return GetKMin(nums1, 0, nums1.Length - 1, nums2, 0, nums2.Length - 1, k)*1.0;

    }

    public int GetKMin(int[]nums1, int start1, int end1, int[] nums2, int start2, int end2, int k)
        {
            
            int len1 = end1 - start1 + 1;
            int len2 = end2 - start2 + 1;
            if (len1 > len2) return GetKMin(nums2, start2, end2, nums1, start1, end1, k);
            if (len1 == 0) return nums2[start2 + k - 1];
            if (k == 1) return Math.Min(nums1[start1], nums2[start2]);
            if (nums1[start1 + Math.Min(k / 2,len1)  - 1] > nums2[start2 + Math.Min(k / 2, len2)  - 1]) return GetKMin(nums1, start1, end1, nums2, start2 + Math.Min(k / 2, len2), end2, k-(Math.Min(k / 2, len2)));
            else
            {
                return GetKMin(nums1, start1 + Math.Min(k / 2, len1) , end1, nums2, start2, end2, k -(Math.Min(k / 2, len1) ));
            }
            
        }
}
