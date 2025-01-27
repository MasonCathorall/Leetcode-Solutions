public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] sum = new int[2];

        for(int i = 0; i < nums.Length-1; i++){
            for(int k = i + 1; k < nums.Length; k++){
                if((nums[i] + nums[k]) == target){
                    sum[0] = i;
                    sum[1] = k;
                }
            }
        }

        return sum;
        
    }
}