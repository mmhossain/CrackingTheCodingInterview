namespace CrackingTheCodingInterview_csharp.LinkedLists;

/*
    2.3 Delete Middle Node: Implement an algorithm to delete a node in the middle (i.e., any node but
        the first and last node, not necessarily the exact middle) of a singly linked list, given only 
        access to that node.
*/
public class DeleteMiddleNode
{
    /*
        Time: O(n)
        Space: O(1)
            n = number of nodes in the linked list
    */
    public bool DeleteNode(SListNode node)
    {
        if (node == null || node.Next == null)
            return false;

        SListNode nextNode = node.Next;
        node.Value = nextNode.Value;
        node.Next = nextNode.Next;

        return true;
    }
}