namespace CrackingTheCodingInterview_csharp.LinkedLists;

/*
    2.1 Remove Dups: Write code to remove duplicates from an unsorted linked list.
        FOLLOW UP: How would you solve this problem if a temporary buffer is not allowed? 
*/
public class RemoveDuplicates
{
    /*
        Time: O(n)
        Space: O(n)
            n = number of nodes in the Linked List
    */
    public void DeleteDups_ApproachI(SListNode node)
    {
        ISet<int> seen = new HashSet<int>();
        SListNode previous = null;

        while (node != null)
        {
            if (seen.Contains(node.Value))
                previous.Next = node.Next;
            else
            {
                seen.Add(node.Value);
                previous = node;
            }

            node = node.Next;
        }
    }

    /*
        Time: O(n^2)
        Space: O(1)
            n = number of nodes in the Linked List
    */
    public void DeleteDups_ApproachII(SListNode node)
    {
        SListNode current = node;

        while (current != null)
        {
            SListNode runner = current;

            while (runner.Next != null)
            {
                if (runner.Next.Value == current.Value)
                    runner.Next = runner.Next.Next;
                else
                    runner = runner.Next;
            }

            current = current.Next;
        }
    }
}