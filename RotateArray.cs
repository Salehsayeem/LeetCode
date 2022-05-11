﻿namespace BinarySearch
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            int[] result = new int[nums.Length];
            int n = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                result[(k + i) % nums.Length] = nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = result[i];
            }

            return;
        }
    }
}
