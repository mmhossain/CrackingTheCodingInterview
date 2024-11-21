using CrackingTheCodingInterview_csharp.LinkedLists;

namespace CrackingTheCodingInterview_csharpTests;

[TestClass]
public class LinkedListsTests
{
    private readonly DeleteSListNode _deleteSListNode;

    public LinkedListsTests()
    {
        _deleteSListNode = new DeleteSListNode();    
    }

    [TestMethod]
    public void DeleteNodeTest()
    {
        // Arrange
        SListNode head = new SListNode(1) { Next = new SListNode(2) { Next = new SListNode(3) } };

        // Act
        SListNode updatedHead = _deleteSListNode.DeleteNode(head, 2);

        // Assert
        Assert.AreEqual(1, updatedHead.Value);
        Assert.AreEqual(3, updatedHead.Next.Value);
    }
}