public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> roman = new Dictionary<char, int>(){
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        int num = 0;

        for(int i = 0; i < s.Length; i++){
            if(i + 1 < s.Length && roman[s[i]] < roman[s[i + 1]]){
                num -= roman[s[i]];
            } else {
                num += roman[s[i]];
            }
        }
        return num;
    }
}