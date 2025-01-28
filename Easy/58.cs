public class Solution {
    public int LengthOfLastWord(string s) {
        s = s.Trim();
        string[] strs = s.Split(" ");
        return strs[strs.Length-1].Length;
    }
}