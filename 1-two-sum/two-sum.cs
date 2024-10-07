public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int s = 0;
        int e = 1;
        int n = nums.Length;
        int[] result = new int[2];
        while (s<n-1){

          if (nums[s] + nums[e] == target)
          {
              result[0] = s;
              result[1] = e;
          }

          if (e < n-1)
          {
              e++;
          }
          else
          {
            s++;
            e = s+1;
          }
        }
      return result;
}}