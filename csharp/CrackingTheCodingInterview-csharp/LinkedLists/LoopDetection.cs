namespace CrackingTheCodingInterview_csharp.LinkedLists;

/*
    2.8 Loop Detection: Given a circular linked list, implement an algorithm that returns the node 
        at the beginning of the loop.
*/
public class LoopDetection
{
    /*
        Time: O(n)
        Space: O(1)
            n = number of nodes in the list
    */
    public SListNode FindBeginning_ApproachI(SListNode head)
    {
        SListNode slow = head;
        SListNode fast = head;

        while (fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;

            if (slow == fast) break;
        }

        if (fast == null || fast.Next == null)
            return null;

        slow = head;
        while (slow != fast)
        {
            slow = slow.Next;
            fast = fast.Next;
        }

        return slow;
    }

    /*
        Time: O(n)
        Space: O(n)
            n = number of nodes in the list
    */
    public SListNode FindBeginning_ApproachII(SListNode head)
    {
        ISet<SListNode> seen = new HashSet<SListNode>();

        while (head != null)
        {
            if (seen.Contains(head)) 
                return head;

            seen.Add(head);
            head = head.Next;
        }

        return null;
    }
}