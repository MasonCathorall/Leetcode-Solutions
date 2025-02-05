public class Solution {
    public int StrStr(string haystack, string needle) {
        // try using substrings here 
        // maybe inside a for loop use substring
        // check length of strings to check bounds

        if(needle.Length > haystack.Length && needle.Length != haystack.Length) return -1;

        for(int i = 0; i < haystack.Length - needle.Length + 1; i++){
            string sub = haystack.Substring(i, needle.Length);
            if(sub == needle) return i;
        }
        return -1;
    }
}