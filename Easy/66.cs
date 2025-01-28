public class Solution {
    public int[] PlusOne(int[] digits) {
        digits[digits.Length-1] = digits[digits.Length-1] + 1;
        for(int i = digits.Length - 1; i >= 0; i--){
            if(digits[i] == 10 && i != 0) {
                digits[i] = 0;
                if(i != 0) digits[i-1]++;
            }
        }

        if(digits[0] == 10){
            int[] d = new int[digits.Length+1];
            d[0] = 1;
            digits[0] = 0;
            for(int i = 1; i < digits.Length + 1; i++){
                d[i] = digits[i-1];
            }
            return d;
        } else {
            return digits;
        }
    }
}