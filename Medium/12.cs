public class Solution {
    public string IntToRoman(int num) {
        Dictionary<int, string> roman = new Dictionary<int, string>(){
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {400, "CD"},
            {100, "C"},
            {90, "XC"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"}
        };

        string ans = "";

        foreach(KeyValuePair<int, string> kv in roman){
            while(num >= kv.Key){
                ans += kv.Value;
                num -= kv.Key;
            }
        }

        return ans;
    }
}