public class Solution {
    public bool hasDuplicate(int[] nums) {
        Array.Sort(nums);
        bool result=false;
        int i=0;
        for(; i<nums.Length - 1;i++){
            if(nums[i]==nums[i+1]){
                result=true;
            }
        }
        return result;
    }
}