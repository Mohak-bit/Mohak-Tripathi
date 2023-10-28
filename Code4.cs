/* 
Question 4 : 
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

*/

int[] nums = new int[] {2,7,11,15};
int target = 9;

int[] TwoSum(int[] nums, int target) {
    for (int i = 0; i < nums.Length; i++) {
        for (int j = 0; j < nums.Length; j++) {
            if (i != j && nums[i] + nums[j] == target) {
                return new int[] {i, j};
            }
        }
    }
    return new int[] {};
}

int[] result = TwoSum(nums, target);
Console.WriteLine(result[0] + " " + result[1]);
