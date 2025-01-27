public class Solution {
    public int RemoveElement(int[] nums, int val) {
        ArrayList a = new ArrayList();
        int k = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] != val){
                a.Add(nums[i]);
            }
        }

        foreach(int i in a){
            nums[k] = i;
            k++;
        }
        return k;
    }
}