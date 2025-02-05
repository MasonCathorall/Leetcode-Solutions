public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int len = nums.Length;
        HashSet<int> n = new HashSet<int>();
        for(int i = 0; i < len; i++){
            n.Add(nums[i]);
        }
        len = 0;
        foreach(int i in n){
            nums[len] = i;
            len++;
        }
        return len;
    }
}