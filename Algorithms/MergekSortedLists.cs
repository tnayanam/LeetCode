// Source : https://leetcode.com/problems/merge-k-sorted-lists/ 
// Author : codeyu 
// Date : 2016年10月10日 20:20:15 

/**********************************************************************************
*
* 
* Merge k sorted linked lists and return it as one sorted list.
* Analyze and describe its complexity.
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
    public class Solution023 
    {
        public static ListNode<int> MergeKLists(ListNode<int>[] lists) 
        {
            if(lists.Length == 0) return null;
            var right = lists.Length - 1;
            while(right > 0)
            {
                var left = 0;
                while(left < right)
                {
                    lists[left] = MergeTwoLists(lists[left],lists[right]);
                    left++;
                    right--;
                }
            }
            return lists[0];
        }
        private static ListNode<int> MergeTwoLists(ListNode<int> l1, ListNode<int> l2) 
        {
            ListNode<int> dummy = new ListNode<int>(0);
            ListNode<int> lastNode = dummy;
            
            while (l1 != null && l2 != null) {
                if (l1.Val < l2.Val) {
                    lastNode.Next = l1;
                    l1 = l1.Next;
                } else {
                    lastNode.Next = l2;
                    l2 = l2.Next;
                }
                lastNode = lastNode.Next;
            }
            
            if (l1 != null) 
            {
                lastNode.Next = l1;
            } 
            if (l2 != null)  
            {
                lastNode.Next = l2;
            }
            
            return dummy.Next;
        }
    }
}

