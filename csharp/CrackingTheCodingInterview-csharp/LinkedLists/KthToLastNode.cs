namespace CrackingTheCodingInterview_csharp.LinkedLists;

/*
    2.2 Return Kth to Last: Implement an algorithm to find the kth to last element of a singly 
        linked list.
*/
public class KthToLastNode
{
    /*
        Time: O(n)
        Space: O(n)
            n = number of nodes in the Linked List
    */
    public SListNode KthToLast_ApproachI(SListNode head, int k)
    {
        return helper(head, k, [0]);    
    }

    private SListNode helper(SListNode head, int k, int[] index)
    {
        if (head == null)
            return null;

        SListNode node = helper(head.Next, k, index);
        index[0]++;

        if (index[0] == k)
            return head;

        return node;
    }

    /*
        Time: O(n)
        Space: O(1)
            n = number of nodes in the Linked List
    */
    public SListNode KthToLast_ApproachII(SListNode head, int k)
    {
        SListNode p1 = head, p2 = head;

        for (int i = 0; i < k; i++)
        {
            if (p2 == null)
                return null;

            p2 = p2.Next;
        }

        while (p2 != null)
        {
            p1 = p1.Next;
            p2 = p2.Next;
        }

        return p1;
    }
}