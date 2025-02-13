public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        List<int> l = new List<int>();

        for(int i = 0; i < nums.Length; i++){
            if(l.Contains(nums[i])) return true;
            else {
                l.Add(nums[i]);
            }
        }

        return false;
    }
}