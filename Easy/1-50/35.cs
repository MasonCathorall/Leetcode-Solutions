public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int low = 0;
        int mid;
        int pos = -1;
        int high = nums.Length - 1;
        while(low <= high){
            mid = low + (high - low) / 2;
            if(nums[mid] == target) return mid;
            else if(nums[mid] > target){
                high = mid - 1;
                pos = mid;
            }
            else {
                low = mid + 1;
                pos = mid + 1;
            } 
        }
        return pos;
    }
}