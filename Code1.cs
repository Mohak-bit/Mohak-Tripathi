/*
Question 1 : 
Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.


Example 1:
Input: nums = [1,2,3,1]
Output: true

Example 2:
Input: nums = [1,2,3,4]
Output: false

*/

int[] nums = new int[] {1,2,3,1};


bool ContainsDuplicate(int[] nums) {
    for (int i = 0; i < nums.Length; i++) {
        for (int j = 0; j < nums.Length; j++) {
            if (i != j && nums[i] == nums[j]) {
                return true;
            }
        }
    }
    return false;
}

bool result = ContainsDuplicate(nums);
Console.WriteLine(result);

