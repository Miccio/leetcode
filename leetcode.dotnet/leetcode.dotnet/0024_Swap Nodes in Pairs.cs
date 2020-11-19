using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace leetcode.dotnet
{
    class _0024_Swap_Nodes_in_Pairs
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
            public ListNode SwapPairs(ListNode head)
            {
                var root = new ListNode(0);
                root.next = head;
                ListNode pre = root;
                ListNode nodeA = head;
                ListNode nodeB = null;
                if (nodeA != null)
                {
                    nodeB = nodeA.next;
                }

                while (nodeA != null && nodeB != null)
                {
                    var next = nodeB.next;
                    pre.next = nodeB;
                    nodeB.next = nodeA;
                    nodeA.next = next;

                    pre = nodeA;
                    if (pre != null)
                    {
                        nodeA = pre.next;
                    }

                    if (nodeA != null)
                    {
                        nodeB = nodeA.next;
                    }
                }

                return root.next;
            }
        }
    }
}
