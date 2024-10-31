//better solution
public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        //each key in numsDict is a number from nums[]
        Dictionary<int, int> numsDict = new Dictionary<int, int>();

        for(int i=0; i<nums.Length; i++){

            /*  we use one loop instead of two to search for the complement 
                of the current num[i] in numsDict   */
            int complement = target - nums[i]; 

            //check if complement exists in dictionary return it with the number it complements
            if(numsDict.ContainsKey(complement)) {
                return new int[] {numsDict[complement] , i};
            }
            
            //add it to the dictionary for future iterations (may find pairs later)
            numsDict[nums[i]] = i; 
        }
        
        return new int[]{};   //empty return if no spairs found
    }
}