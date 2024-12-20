﻿namespace CrackingTheCodingInterview_csharp.LinkedLists;

public class DeleteSListNode
{
    /*
        Time: O(n)
        Space: O(1)
            n = number of nodes in the linked list
    */
    public SListNode DeleteNode(SListNode head, int val)
    {
        SListNode current = head;

        if (current.Value == val)
            return head.Next;

        while (current.Next != null)
        {
            if (current.Next.Value == val)
            {
                current.Next = current.Next.Next;
                return head;
            }

            current = current.Next;
        }

        return head;
    }
}