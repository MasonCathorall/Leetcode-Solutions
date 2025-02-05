public class Solution {
    public bool IsPalindrome(string s) {
        string str = s.Trim();
        char[] c = str.Where(c => (char.IsLetterOrDigit(c) )).ToArray();
        str = new string(c);
        str = str.ToLower();
        Console.WriteLine(str);
        int n = str.Length;
        int mid;
        if(n % 2 != 0) {
            mid = (n-1)/2;
        } else {
            mid = n/2;
        }

        for(int i = 0; i < mid; i++){
            if(str[i] != str[n-1]){
                return false;
            }
            n--;
        }
        return true;
    }
}