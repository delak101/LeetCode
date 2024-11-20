public class Solution {
    public int RemoveElement(int[] nums, int val) {
        if (nums.Length == 0) return 0;
        int k = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            //[1,2,2,3,3,4,5]
            if(nums[i] != val)
            {
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
}