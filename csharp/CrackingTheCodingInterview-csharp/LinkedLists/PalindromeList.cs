namespace CrackingTheCodingInterview_csharp.LinkedLists;

/*
    2.6 Palindrome: Implement a function to check if a linked list is a palindrome.
*/
public class PalindromeList
{
    /*
        Time: O(n)
        Space: O(1)
            n = number of nodes in the list
    */
    public bool IsPalindrome_ApproachI(SListNode head)
    {
        SListNode reversedHead = reverseAndClone(head);
        return areEqual(head, reversedHead);
    }

    private SListNode reverseAndClone(SListNode node)
    {
        SListNode head = null;

        while (node != null)
        {
            SListNode n = new SListNode(node.Value);
            n.Next = head;
            head = n;
            node = node.Next;
        }

        return head;
    }

    private bool areEqual(SListNode l1, SListNode l2)
    {
        while (l1 != null && l2 != null)
        {
            if (l1.Value != l2.Value)
                return false;

            l1 = l1.Next;
            l2 = l2.Next;
        }

        return l1 == null && l2 == null;
    }

    /*
        Time: O(n)
        Space: O(n)
            n = number of nodes in the list
    */
    public bool IsPalindrome_ApproachII(SListNode head)
    {
        Stack<int> stack = [];
        SListNode slow = head;
        SListNode fast = head;

        while (fast != null && fast.Next != null)
        {
            stack.Push(slow.Value);

            slow = slow.Next;
            fast = fast.Next.Next;
        }

        // handle odd length
        if (fast != null)
            slow = slow.Next;

        while (slow != null)
        {
            if (stack.Pop() != slow.Value)
                return false;

            slow = slow.Next;
        }

        return true;
    }
}