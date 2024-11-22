public class Solution {
    public int LengthOfLastWord(string s) {
        int lastWord = 0;
        bool isWord = false;
        for(int i = s.Length - 1; i >= 0; i--)
        {
            if(s[i] == ' '){
                if(isWord){
                    return lastWord;
                }
            } else {
                isWord = true;
                lastWord++;
            }
        }
        return lastWord;
    }
}