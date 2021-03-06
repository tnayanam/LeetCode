// Source : https://leetcode.com/problems/remove-nth-node-from-end-of-list/ 
// Author : codeyu 
// Date : 2016年10月9日 14:16:38 

/***************************************************************************************
*
* Given a linked list, remove the nth node from the end of list and return its head.
* 
* 
* For example,
* 
* 
*    Given linked list: 1->2->3->4->5, and n = 2.
* 
*    After removing the second node from the end, the linked list becomes 1->2->3->5.
* 
* 
* 
* Note:
* Given n will always be valid.
* Try to do this in one pass.
* 
*
**********************************************************************************/

using Algorithms.Utils;
namespace Algorithms
{
    public class Solution019 
    {
        public static ListNode<int> RemoveNthFromEnd(ListNode<int> head, int n) 
        {
            ListNode<int> start = new ListNode<int>(0);
            start.Next = head;
            ListNode<int> fast = start, slow = start;
            while(n > 0)
            {
                fast = fast.Next;
                n--;
            }
            while(fast.Next != null)
            {
                fast = fast.Next;
                slow = slow.Next;
            }
            slow.Next = slow.Next.Next;
            return start.Next;
        }
    }
}   

