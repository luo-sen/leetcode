using System;
using System.Collections.Generic;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }


        // check if array contains 2 numbers that can be sum to sum.
        // return results indexes
        public static int[] TwoSum(int[] nums, int sum)
        {
            var dic = new Dictionary<int, int>();
            for (int i=0;i<nums.Length;i++)
            {
                int comp = sum - nums[i];
                if (dic.ContainsKey(comp)) return new int[] { i, dic[comp] };
                else if(!dic.ContainsKey(nums[i]))dic.Add(nums[i], i);
            }
            throw new Exception();

        }
    }


    
}
