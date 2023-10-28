/*
Question 7 : **
Reverse an array without using another temporary array.

Input:  21 43 22 67 43 12 4
Output :  4 12 43 67 22 43 21

*/

int[] nums = new int[] {21, 43, 22, 67, 43, 12, 4};


for (int i = 0; i < nums.Length/2; i++) {
    int x = nums[nums.Length-1-i];
    nums[nums.Length-1-i] = nums[i];
    nums[i] = x;

}
for (int i = 0; i < nums.Length; i++) {
    Console.Write(nums[i]+",");
}

