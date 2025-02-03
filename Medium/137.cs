public class Solution {
    public int SingleNumber(int[] nums) {
        var result = 
            from num in nums
            group nums by num into grp
            where grp.Count() == 1
            select grp.Key;

            return result.FirstOrDefault();

    }
}