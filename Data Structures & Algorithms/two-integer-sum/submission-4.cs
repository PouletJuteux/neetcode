public class Solution {
    public int[] TwoSum(int[] nums, int target) {        
      for(int i = 0; i < nums.Length; i++){
        int pos = Array.IndexOf(nums, target - nums[i]);
        if(pos > -1 && pos != i){
          int[]result=new int[2]{i, pos};
          Array.Sort(result);
            return result;
        }
      }
      return new int[0];
    }
}
