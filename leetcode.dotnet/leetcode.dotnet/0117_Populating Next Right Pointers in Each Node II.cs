using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    public class _0117_Populating_Next_Right_Pointers_in_Each_Node_II
    {
        public class Solution
        {
            public Node Connect(Node root)
            {
                ConnectWithFirstParent(root);
                return root;
            }

            public void ConnectWithFirstParent(Node firstParent)
            {
                if (firstParent == null)
                {
                    return;
                }

                Node curParent = firstParent;
                Node firstChild = null;
                Node preChild = null;
                Node curChild = null;

                while (curParent != null)
                {
                    curChild = curParent.left;
                    if (curChild != null)
                    {
                        if (firstChild == null)
                        {
                            firstChild = curChild;
                        }
                        else
                        {
                            preChild.next = curChild;
                        }

                        preChild = curChild;
                    }

                    curChild = curParent.right;
                    if (curChild != null)
                    {
                        if (firstChild == null)
                        {
                            firstChild = curChild;
                        }
                        else
                        {
                            preChild.next = curChild;
                        }

                        preChild = curChild;
                    }

                    curParent = curParent.next;
                }

                ConnectWithFirstParent(firstChild);
            }
        }
    }
}
