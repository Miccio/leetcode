namespace leetcode.dotnet
{
    public class _0141_Linked_List_Cycle
    {
public class Solution
{
    public bool HasCycle(ListNode head)
    {
        if (head == null)
        {
            return false;
        }

        var fastStep = head.next?.next;
        var slowStep = head.next;
        while (fastStep != null)
        {
            if (fastStep == slowStep)
            {
                return true;
            }

            fastStep = fastStep.next?.next;
            slowStep = slowStep.next;
        }

        return false;
    }
}
    }
}
