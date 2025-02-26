public class Solution {
    public int FindDuplicate(int[] nums) {
        Dictionary<int, int> mp = new Dictionary<int, int>();
        int ans = 0;

        for(int i = 0; i < nums.Length; i++){
            if(!mp.ContainsKey(nums[i])) mp.Add(nums[i], 1);
            else return nums[i];
        } 

        return ans;
    }
}