public class Solution {
    public int CountPrimes(int n) {
        bool[] isComposite = new bool[n+1];
        int count = 0;

        for(int i = 2; i < n; i++){
            if(isComposite[i]){
                continue;
            }
            count++;

            for(int k = i * 2; k < n; k += i){
                isComposite[k] = true;
            }
        }

        return count;
    }
}