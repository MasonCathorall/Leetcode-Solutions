public class Solution {
    public int TrailingZeroes(int n) {
        int numZero = 0;
        while(n > 0){
            n /= 5 ;
            numZero += n;
        }

        return numZero;
    }
}