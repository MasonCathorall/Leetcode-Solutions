public class Solution {
    public bool IsValid(string s) {


        Stack<char> stack = new Stack<char>();

        foreach(var c in s){
            switch(c){
                case '(':
                    stack.Push(')');
                    break;
                case '{':
                    stack.Push('}');
                    break;
                case '[':
                    stack.Push(']');
                    break;
                case ')':
                case '}':
                case ']':
                    if(stack.Count == 0 || stack.Pop() != c) return false;
                    break;
            }
        }
        return stack.Count == 0;
    }
}