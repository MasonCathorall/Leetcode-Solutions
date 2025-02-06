public class Solution {
    public int Reverse(int x) {
        int result = 0;

        int positiveOver = int.MaxValue / 10;
        int negativeOver = int.MinValue / 10;

        for(; x != 0; x/=10){
            if(result > positiveOver || result < negativeOver){
                return 0;
            }
            result = result * 10 + x % 10;
        }
        return result;
    }
}