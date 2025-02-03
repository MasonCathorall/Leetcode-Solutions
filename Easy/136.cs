public class Solution {
    public int SingleNumber(int[] nums) {
        Dictionary<int, int> d = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            if(d.ContainsKey(nums[i])){
                 d[nums[i]]++;
            } else {
                d.Add(nums[i], 1);
            }
        }

        int val = d.FirstOrDefault(x => x.Value == 1).Key;

        return val;
    }
}