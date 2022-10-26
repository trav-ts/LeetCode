using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    /// <summary>
    /// LeetCode problem 523 Continuous Subarry Sum
    /// 
    /// Given an integer array nums and an integer k, 
    /// return true if nums has a continuous subarray 
    /// of size at least two whose elements sum up to a 
    /// multiple of k, or false otherwise.
    /// 
    /// An integer x is a multiple of k if there exists 
    /// an integer n such that x = n * k. 0 is always a multiple of k.
    /// 
    /// </summary>
    internal class ContinuousSubarraySum
    {
        /// <summary>
        /// 
        /// From what I understand, I should be using two pointers.
        /// They will check the sum of each and all numbers in the array 
        /// and return true if that sum is divisable by k. But the sum has to be continuous. 
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public bool CheckSubarraySum(int[] nums, int k)
        {
            // Lets start with the two pointers
            int left = 0;
            int right = 0;

            // Next we go through the entire array from left to right.
            for(int i = 0; i < nums.Length; i++)
            {

            }
            return false;
        }
    }
}
