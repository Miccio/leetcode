using System.Collections.Generic;

namespace leetcode.dotnet
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }

        public static ListNode BuildList(List<int> nums)
        {
            var root = new ListNode(0);
            var prev = root;
            for (var i = 0; i < nums.Count; i++)
            {
                var node = new ListNode(nums[i]);
                prev.next = node;
                prev = prev.next;
            }

            return root.next;
        }

        public static List<int> Output(ListNode root)
        {
            var ret = new List<int>();
            while (root != null)
            {
                ret.Add(root.val);
                root = root.next;
            }

            return ret;
        }
    }
}
