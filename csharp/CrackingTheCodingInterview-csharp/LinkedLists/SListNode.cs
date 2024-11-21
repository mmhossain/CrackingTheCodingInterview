namespace CrackingTheCodingInterview_csharp.LinkedLists;

public class SListNode
{
    public int Value { get; set; }
    public SListNode Next { get; set; }

    public SListNode()
    {
        
    }

    public SListNode(int val)
    {
        Value = val;
    }

    public void AppendToTail(int val)
    {
        SListNode node = new SListNode(val);
        
        SListNode current = this;

        while (current.Next != null)
            current = current.Next;

        current.Next = node;
    }
}