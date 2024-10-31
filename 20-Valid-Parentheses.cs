public class Solution {
    public bool IsValid(string s) {
        /**
          *we can create a stack of characters 
          *add opened brackets or parantheses to the top of stack 
          *if closed brackets found add it next if not return false;
        */

        // Create a stack of characters
        Stack<char> brackStack = new Stack<char>();

        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[') {
                brackStack.Push(s[i]);
            } else {
                if (brackStack.Count == 0) {
                    return false;
                }

                char bracks = brackStack.Pop();

                if (bracks == '(' && s[i] != ')') {
                    return false;
                } else if (bracks == '[' && s[i] != ']') {
                    return false;
                } else if (bracks == '{' && s[i] != '}') {
                    return false;
                }
            }
        }
        return brackStack.Count == 0;
    }
}