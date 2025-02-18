public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] c1 = s.ToCharArray();
        char[] c2 = t.ToCharArray();
        
        Array.Sort(c1);
        Array.Sort(c2);

        return c1.SequenceEqual(c2);
    }
}