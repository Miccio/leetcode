using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    public class _0002_Add_Two_Numbers
    {
        /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
        public class Solution
        {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                var flag = 0;
                ListNode root = new ListNode(0);
                var prev = root;
                while (l1 != null || l2 != null)
                {
                    var val = (l1?.val ?? 0) + (l2?.val ?? 0) + flag;
                    flag = val / 10;
                    val = val % 10;

                    var node = new ListNode(val);
                    prev.next = node;
                    prev = prev.next;

                    l1 = l1?.next;
                    l2 = l2?.next;
                }

                if (flag > 0)
                {
                    var node = new ListNode(flag);
                    prev.next = node;
                }

                return root.next;
            }
        }
    }
}
