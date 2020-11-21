using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    class _0148_Sort_List
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
            public ListNode SortList(ListNode head)
            {
                if (head == null)
                {
                    return head;
                }

                var pre = head;
                var cur = head.next;
                while (cur != null)
                {
                    if (cur.val > pre.val)
                    {
                        pre = pre.next;
                        cur = cur.next;
                        continue;
                    }

                    // remove cur node from link
                    var next = cur.next;
                    pre.next = next;

                    if (cur.val <= head.val)
                    {
                        cur.next = head;
                        head = cur;
                    }
                    else
                    {
                        var pre2 = head;
                        while (pre2.next != null && pre2.next != next && cur.val > pre2.next.val)
                        {
                            pre2 = pre2.next;
                        }

                        cur.next = pre2.next;
                        pre2.next = cur;
                    }

                    cur = next;
                }

                return head;
            }
        }
    }
}
