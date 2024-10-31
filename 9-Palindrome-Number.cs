public class Solution {
    public bool IsPalindrome(int x) {
        int _x = 0, LastDigit, temp = x;
        while(temp>0){
            LastDigit = (temp % 10);
            _x = _x * 10 + LastDigit;
            temp /= 10;
        }
        if(_x == x){return true;}
        else{return false;}
    }
}