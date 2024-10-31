public class Solution {

    public int RomanToInt(string s) {
        
        int Num = 0;
        
        Dictionary<char, int> roman = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        // we subtract I from V or X if it came before them
        // and X from L and C if it came before 
        // and C from D and M if it came before

        for (int i = 0; i < s.Length; i++){
            if ((i + 1 < s.Length) && (roman[s[i]] < roman[s[i + 1]])) {
                Num -= roman[s[i]];
            } else {
                Num += roman[s[i]];
            }
        }
        return Num;
    }
}