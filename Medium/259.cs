public class Solution {
    private int TwoSum(int[] nums, int start, int target){
        int sum = 0;
        int left = start;
        int right = nums.Length - 1;

        while(left < right){
            if(nums[left] + nums[right] < target) {
                sum += right - left;
                left++;
            } else {
                right--;
            }
        }

        return sum;
    }

    public int ThreeSumSmaller(int[] nums, int target) {
        Array.Sort(nums);
        int sum = 0;
        for(int i = 0; i < nums.Length - 2; i++){
            sum += TwoSum(nums, i + 1, target - nums[i]);
        }
        return sum;
    }
}