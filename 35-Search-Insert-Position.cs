/*
i realized the the problem needs o(log n) complexity
my bad
here's the corrected solutin with binary search
*/

public class Solution {
    public int SearchInsert(int[] nums, int target) {

        int max = nums.Length - 1 , min = 0;   

        while(min <= max)
        {
            int mid = min + (max - min) /2;
            
            if(nums[mid] == target){
                return mid;
            } else if(nums[mid] < target) {
                min = mid + 1;
            } else {
                max = mid - 1;
            }
        }
        return min;
    }
}