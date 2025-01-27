public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string pre = "";
        for(int i = 0; i < strs[0].Length; i++){
            char c = strs[0][i];
            for(int k = 1; k < strs.Length; k++){
                if(i >= strs[k].Length || strs[k][i] != c) return pre;
            }
            pre += c;
        }
        return pre;
    }
}