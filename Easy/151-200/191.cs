public class Solution {
    public int HammingWeight(int n) {
        string s = Convert.ToString(n, 2);
        int count = 0;
        foreach(char c in s){
            if(c == '1') count++;
        }

        return count;
    }
}