/**
* \sadbutsad\ 0-8 9
* \sad\ 0-2 3
* i<6
* 0 < 3 && 1+1 == 1
*/
public class Solution {
    public int StrStr(string haystack, string needle) {
        for(int i = 0; i <= haystack.Length - needle.Length; i++) 
        {
            int k = 0;
            while (k < needle.Length && haystack[i + k] == needle[k])
            {
                k++;
            }
            if(k == needle.Length) 
            {
                return i;
            }            
        }
        return -1;
    }
}