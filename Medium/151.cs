public class Solution {
    public string ReverseWords(string s) {
        string[] s1 = s.Split(" ");

        Array.Reverse(s1);

        StringBuilder sb = new StringBuilder();

        for(int i = 0; i < s1.Length; i++){
            if(s1[i] == " "){
                s1[i] = "";
            }
        }


        return string.Join(" ", s1.Where(x => !string.IsNullOrEmpty(x)));
    }
}