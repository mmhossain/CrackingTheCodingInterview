namespace CrackingTheCodingInterview_csharp.LinkedLists;

/*
    2.4 Partition: Write code to partition a linked list around a value x, such that all nodes less 
        than x come before all nodes greater than or equal to x. If x is contained within the list 
        the values of x only need to be after the elements less than x (see below). The partition 
        element x can appear anywhere in the "right partition"; it does not need to appear between 
        the left and right partitions.
*/
public class PartitionList
{
    /*
        Time: O(n)
        Space: O(1)
            n = number of nodes in the linked list
    */
    public SListNode Partition_ApproachI(SListNode node, int x)
    {
        SListNode beforeStart = null;
        SListNode beforeEnd = null;
        SListNode afterStart = null;
        SListNode afterEnd = null;

        while (node != null)
        {
            SListNode next = node.Next;
            node.Next = null;

            if (node.Value < x)
            {
                if (beforeStart == null)
                {
                    beforeStart = node;
                    beforeEnd = beforeStart;
                }
                else
                {
                    beforeEnd.Next = node;
                    beforeEnd = node;
                }
            }
            else
            {
                if (afterStart == null)
                {
                    afterStart = node;
                    afterEnd = afterStart;
                }
                else
                {
                    afterEnd.Next = node;
                    afterEnd = node;
                }
            }

            node = next;
        }

        if (beforeStart == null)
            return afterStart;

        beforeEnd.Next = afterStart;

        return beforeStart;
    }

    /*
        Time: O(n)
        Space: O(1)
            n = number of nodes in the linked list
    */
    public SListNode Partition_ApproachII(SListNode node, int x)
    {
        SListNode head = node;
        SListNode tail = node;

        while (node != null)
        {
            SListNode next = node.Next;

            if (node.Value < x)
            {
                node.Next = head;
                head = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }

            node = next;
        }

        tail.Next = null;

        return head;
    }
}