public class Solution {
    public int MajorityElement(int[] nums) {
        int mid = 0;
        if(nums.Length % 2 != 0) mid =(nums.Length + 1)/2;
        else mid = nums.Length/2;
        Dictionary<int, int> d = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            if(d.ContainsKey(nums[i])) d[nums[i]]++;
            else d.Add(nums[i], 1);
        }
        


        return d.FirstOrDefault(x => x.Value >= mid).Key;
    }
}