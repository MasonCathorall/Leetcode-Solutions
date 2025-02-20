public class Solution {
    public int[] SingleNumber(int[] nums) {
        Dictionary<int, int> d = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            if(!d.ContainsKey(nums[i])){
                d.Add(nums[i], 1);
            } else {
                d[nums[i]]++;
            }
        }

        int count = 0;
        int[] a = new int[2];

        foreach(KeyValuePair<int, int> kvp in d){
            if(kvp.Value == 1){
                a[count] = kvp.Key;
                count++;
            }
        }

        return a;
    }
}