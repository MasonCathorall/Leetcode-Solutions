public class Solution {

    static string trimZeros(string s){
        int firstOne = s.IndexOf('1');
        return (firstOne == -1) ? "0" : s.Substring(firstOne);
    }
    public string AddBinary(string a, string b) {
        string s1 = trimZeros(a);
        string s2 = trimZeros(b);

        int n = s1.Length;
        int m = s2.Length;

        if(n < m){
            return AddBinary(s2, s1);
        }

        int j = m - 1;
        int carry = 0;
        char[] ans = new char[n];

        for(int i = n - 1; i >= 0; i--){
            int bit1 = s1[i] - '0';
            int sum = bit1 + carry;

            if(j >= 0) {
                int bit2 = s2[j] - '0';
                sum += bit2;
                j--;
            }

            int bit = sum % 2;
            carry = sum / 2;

            ans[i] = (char)(bit + '0');
        }

        if(carry > 0){
            return '1' + new string(ans);
        }

        return new string(ans);
    }
}