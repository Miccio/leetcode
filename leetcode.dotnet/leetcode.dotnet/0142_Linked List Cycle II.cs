using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.dotnet
{
    public class _0142_Linked_List_Cycle_II
    {
public class Solution
{
    public ListNode DetectCycle(ListNode head)
    {
        if (head == null)
        {
            return null;
        }

        var fastStep = head.next?.next;
        var slowStep = head.next;
        while (fastStep != null)
        {
            if (fastStep == slowStep)
            {
                break;
            }

            fastStep = fastStep.next?.next;
            slowStep = slowStep.next;
        }

        if (fastStep == null)
        {
            return null;
        }

        var oneStep = head;
        while (oneStep != slowStep)
        {
            oneStep = oneStep.next;
            slowStep = slowStep.next;
        }

        return oneStep;
    }
}
    }
}
