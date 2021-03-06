// Source : https://leetcode.com/problems/subsets/ 
// Author : codeyu 
// Date : Tuesday, January 24, 2017 11:56:48 PM 

/**********************************************************************************
*
* 
* Given a set of distinct integers, nums, return all possible subsets.
* 
* Note: The solution set must not contain duplicate subsets.
* 
* 
* For example,
* If nums = [1,2,3], a solution is:
* 
* 
* 
* [
*   [3],
*   [1],
*   [2],
*   [1,2,3],
*   [1,3],
*   [2,3],
*   [1,2],
*   []
* ]
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution078
    {
        public static IList<IList<int>> Subsets(int[] nums)
        {
            if (nums.Length == 0)
            {
                return null;
            }

            IList<int> list = new List<int>();
            Array.Sort(nums);
            return Helper(nums, nums.Length - 1);
        }
        private static IList<IList<int>> Helper(int[] num, int pos)
        {
            if (pos == -1)
            {
                IList<IList<int>> res = new List<IList<int>>();
                IList<int> elem = new List<int>();
                res.Add(elem);
                return res;
            }
            else
            {
                IList<IList<int>> res = Helper(num, pos - 1);
                int size = res.Count;
                for (int i = 0; i < size; i++)
                {
                    IList<int> elem = new List<int>(res[i]);
                    elem.Add(num[pos]);
                    res.Add(elem);
                }
                return res;
            }
        }
    }
}

