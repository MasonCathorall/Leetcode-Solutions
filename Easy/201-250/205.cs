public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if(s.Length != t.Length) return false;
        Dictionary<char, char> d = new Dictionary<char, char>(26);
        HashSet<char> set = new HashSet<char>(26);

        for(int i = 0; i < s.Length; i++){
            if(d.ContainsKey(s[i])){
                if(d[s[i]] != t[i]) return false;
            } else {
                if(set.Contains(t[i])) return false;
                d.Add(s[i], t[i]);
                set.Add(t[i]);
            }
        }
        return true;
    }
}