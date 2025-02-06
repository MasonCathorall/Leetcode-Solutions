public class Solution {
    public int LengthOfLongestSubstring(string s) {
        List<char> list = new List<char>();
        int count = 0;
        if(s.Length == 0) return 0;
        if(s.Length == 1) return 1;
        for(int i = 0; i < s.Length - 1; i++){
            for(int j = i; j < s.Length; j++){
                if(list.Contains(s[j])){
                    break;
                } else {
                    list.Add(s[j]);
                }
            }
            if(list.Count > count) {
                count = list.Count;
            }
            list.Clear();
        }

        return count;
    }
}