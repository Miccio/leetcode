using System.Collections.Generic;

namespace leetcode.dotnet
{
    public class _0116_Populating_Next_Right_Pointers_in_Each_Node
    {
        public class Solution
        {
            public Node Connect(Node root)
            {
                if (root != null)
                {
                    var nodes = new Queue<Node>();
                    nodes.Enqueue(root);
                    Connect(nodes);
                }

                return root;
            }

            public void Connect(Queue<Node> curNodes)
            {
                if (curNodes == null || curNodes.Count == 0)
                {
                    return;
                }

                var nextNodes = new Queue<Node>();
                Node preNode = null;
                while (curNodes.Count > 0)
                {
                    var curNode = curNodes.Dequeue();
                    if (curNode.left != null)
                    {
                        nextNodes.Enqueue(curNode.left);
                    }

                    if (curNode.right != null)
                    {
                        nextNodes.Enqueue(curNode.right);
                    }

                    if (preNode == null)
                    {
                        preNode = curNode;
                    }
                    else
                    {
                        preNode.next = curNode;
                        preNode = curNode;
                    }
                }

                Connect(nextNodes);
            }
        }
    }
}
