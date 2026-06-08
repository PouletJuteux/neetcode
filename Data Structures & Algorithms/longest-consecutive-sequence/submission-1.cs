public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> hashSet = new HashSet<int>(nums);  
        int longest = 0;      
        foreach(int num in nums){
            int length =1;
            while(hashSet.Contains(num+length)){
                length++;
            }
            longest = Math.Max(longest,length);
        }
        return longest;
    }
}
