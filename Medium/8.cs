public class Solution {
    public int MyAtoi(string s) {
        if(string.IsNullOrWhiteSpace(s)) { return 0; }

        bool navigate = false;
        int index = 0;

        while(index < s.Length && s[index] == ' '){
            index++;
        }
        if(s[index] == '-'){
            navigate = true;
            index++;
        } else if(s[index] == '+'){
            index++;
        }

        int posOverFlowHead = int.MaxValue / 10;
        int posOverFlowTail = int.MaxValue % 10;

        int result = 0;

        for(; index < s.Length; index++){
            var digit = s[index] - '0';
            if(digit < 0 || digit > 9) { break; }
            
            if(result > posOverFlowHead || (result == posOverFlowHead  && digit > posOverFlowTail)) {
                return navigate ? int.MinValue : int.MaxValue;
            }

            result = result * 10 + digit;
        }

        return navigate ? -result : result;
    }
}