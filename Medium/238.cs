public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int len = nums.Length;

        int[] l = new int[len];

        l[0] = 1;
        for(int i = 1; i < len; i++){
            l[i] = nums[i - 1] * l[i - 1];
        }

        int R = 1;
        for(int i = len - 1; i >= 0; i--){
            l[i] = l[i] * R;
            R *= nums[i];
        }


        return l;
    }
}