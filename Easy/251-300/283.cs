public class Solution {
    public void MoveZeroes(int[] nums) {
        int wayPt = 0;
        for(int i = 0; i < nums.Count(); i++){
            if(nums[i] != 0){
                int tmp = nums[i];
                nums[i] = nums[wayPt];
                nums[wayPt] = tmp;
                wayPt++;
            }
        }
    }
}