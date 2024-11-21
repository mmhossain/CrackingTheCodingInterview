namespace CrackingTheCodingInterview_csharp.LinkedLists;

/*
    2.5 Sum Lists: You have two numbers represented by a linked list, where each node contains a single
        digit. The digits are stored in reverse order, such that the 1 's digit is at the head of the 
        list. Write a function that adds the two numbers and returns the sum as a linked list.
        
        FOLLOW UP: Suppose the digits are stored in forward order. Repeat the above problem.
*/
public class SumLists
{
    /*
        Time: O(n + m)
        Space: O(1)
            n = number of nodes in list 1
            m = number of nodes in list 2
    */
    public SListNode AddLists_ApproachI(SListNode l1, SListNode l2, int carry)
    {
        if (l1 == null && l2 == null && carry == 0)
            return null;

        int value = carry;
        if (l1 != null)
            value += l1.Value;

        if (l2 != null)
            value += l2.Value;

        SListNode result = new SListNode(value % 10);

        if (l1 != null || l2 != null)
            result.Next = AddLists_ApproachI(l1?.Next, l2?.Next, value / 10);

        return result;
    }

    /*
        Time: O(n + m)
        Space: O(1)
            n = number of nodes in list 1
            m = number of nodes in list 2
    */
    public SListNode AddLists_ApproachII(SListNode l1, SListNode l2)
    {
        int length1 = getLength(l1);
        int length2 = getLength(l2);

        if (length1 < length2)
            l1 = padList(l1, length2 - length1);
        else
            l2 = padList(l2, length1 - length2);

        PartialSum pSum = addListHelper(l1, l2);

        if (pSum.Carry == 0)
            return pSum.Sum;

        return insertBefore(pSum.Sum, pSum.Carry);
    }

    private PartialSum addListHelper(SListNode l1, SListNode l2)
    {
        if (l1 == null && l2 == null)
            return new PartialSum();

        PartialSum pSum = addListHelper(l1.Next, l2.Next);

        int value = pSum.Carry + l1.Value + l2.Value;
        
        pSum.Sum = insertBefore(pSum.Sum, value % 10);
        pSum.Carry = value / 10;

        return pSum;
    }

    private int getLength(SListNode head)
    {
        int length = 0;
        SListNode current = head;

        while (current != null)
        {
            length++;
            current = current.Next;
        }

        return length;
    }

    private SListNode padList(SListNode head, int count)
    {
        for(int i = 0; i < count; i++)
            head = insertBefore(head, 0);

        return head;
    }

    private SListNode insertBefore(SListNode head, int value)
    {
        SListNode node = new SListNode(value);

        if (head != null)
            node.Next = head;

        return node;
    }
}

public class PartialSum
{
    public SListNode Sum { get; set; }
    public int Carry { get; set; }
}