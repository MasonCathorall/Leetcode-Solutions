public class Solution {
    public void ReverseWords(char[] s) {
        string str = new string(s);

        string[] arr = str.Split(' ');

        Array.Reverse(arr);

        str = String.Join(" ", arr);

        for(int i = 0; i < str.Length; i++){
            s[i] = str[i];
        }

        
    }
}