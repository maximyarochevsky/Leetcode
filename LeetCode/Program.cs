﻿//1.Two Sum
//Easy

//Companies
//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
//You may assume that each input would have exactly one solution, and you may not use the same element twice.
//You can return the answer in any order.

//Example 1:

//Input: nums = [2, 7, 11, 15], target = 9
//Output: [0,1]
//Explanation: Because nums[0] +nums[1] == 9, we return [0, 1].
//Example 2:

//Input: nums = [3, 2, 4], target = 6
//Output: [1,2]
//Example 3:

//Input: nums = [3, 3], target = 6
//Output: [0,1]
 
//Constraints:

//2 <= nums.length <= 104
//- 109 <= nums[i] <= 109
//- 109 <= target <= 109
//Only one valid answer exists.

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] array = new int[2];
        array[0] = 0;
        array[1] = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target && i != j)
                {
                    array[0] = i;
                    array[1] = j;
                    return array;
                }
            }
        }
        return array;
    }
}