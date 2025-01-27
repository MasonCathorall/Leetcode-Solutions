public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0) return false;
        string s = x.ToString();
        char[] c = s.ToCharArray();
        Array.Reverse(c);
        if(s == new string(c)) return true;
        else return false;

    }
}