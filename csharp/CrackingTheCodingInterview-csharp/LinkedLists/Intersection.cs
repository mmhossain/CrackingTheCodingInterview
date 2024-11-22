namespace CrackingTheCodingInterview_csharp.LinkedLists;

/*
    2.7 Intersection: Given two (singly) linked lists, determine if the two lists intersect. Return 
        the intersecting node. Note that the intersection is defined based on reference, not value. 
        That is, if the kth node of the first linked list is the exact same node (by reference) as 
        the jth node of the second linked list, then they are intersecting.
*/
public class Intersection
{
    /*
        Time: O(n + m)
        Space: O(1)
            n = number of nodes in the list1
            m = number of nodes in the list2
    */
    public SListNode FindIntersection_ApproachI(SListNode list1, SListNode list2)
    {
        if (list1 == null || list2 == null)
            return null;

        IntersectionResult result1 = getTailAndSize(list1);
        IntersectionResult result2 = getTailAndSize(list2);

        if (result1.Tail != result2.Tail)
            return null;

        SListNode shorter = result1.Size < result2.Size ? list1 : list2;
        SListNode larger = result1.Size > result2.Size ? list1 : list2;

        larger = getKthNode(larger, Math.Abs(result1.Size - result2.Size));

        while (shorter != larger)
        {
            shorter = shorter.Next;
            larger = larger.Next;
        }

        return larger;
    }

    private SListNode getKthNode(SListNode head, int k)
    {
        SListNode current = head;

        while (current != null && k > 0)
        {
            k--;
            current = current.Next;
        }

        return current;
    }

    private IntersectionResult getTailAndSize(SListNode head)
    {
        if (head == null) return null;

        int size = 1;
        SListNode current = head;

        while (current.Next != null)
        {
            size++;
            current = current.Next;
        }

        return new IntersectionResult(current, size);
    }

    private class IntersectionResult
    {
        public SListNode Tail { get; set; }
        public int Size { get; set; }

        public IntersectionResult(SListNode node, int size)
        {
            Tail = node;
            Size = size;
        }
    }

    /*
        Time: O(n + m)
        Space: O(n + m)
            n = number of nodes in the list1
            m = number of nodes in the list2
    */
    public SListNode FindIntersection_ApproachII(SListNode list1, SListNode list2)
    {
        if (list1 == null || list2 == null)
            return null;

        ISet<SListNode> seen = new HashSet<SListNode>();

        while (list1 != null)
        {
            seen.Add(list1);
            list1 = list1.Next;
        }

        while (list2 != null)
        {
            if (seen.Contains(list2))
                return list2;

            list2 = list2.Next;
        }

        return null;
    }
}