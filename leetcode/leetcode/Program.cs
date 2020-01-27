using System;
using System.Collections.Generic;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static bool TwoSum(int[] nums, int sum)
        {
            HashSet<int> dic = new HashSet<int>();
            foreach (int num in nums)
            {
                if (dic.Contains(sum - num)) return true;
                else dic.Add(num);
            }
            return false;

        }
    }


    
}
