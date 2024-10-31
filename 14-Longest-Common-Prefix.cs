public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        //first if the strs array is empty or has one string return ""
        if (strs == null || strs.Length == 0) {
            return "";
        }
        //create a string that has the first sring in the array 
        string prefix = strs[0];
        
        for (int i = 0; i < prefix.Length; i++)
        {
            for (int j = 1; j< strs.Length; j++)
            {
            //check if the current character is within the bounds of the current string
            //and if it matches the character in the prefix
                if (i >= strs[j].Length || prefix[i] != strs[j][i])
                {
                    //update the longest common prefix
                    prefix = prefix.Substring(0, i);
                    break;
                }
            }
        }
        return prefix;
    }
}