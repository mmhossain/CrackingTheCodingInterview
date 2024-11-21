using CrackingTheCodingInterview_csharp.LinkedLists;

namespace CrackingTheCodingInterview_csharpTests;

[TestClass]
public class LinkedListsTests
{
    private readonly DeleteSListNode _deleteSListNode;
    private readonly RemoveDuplicates _removeDuplicates;
    private readonly KthToLastNode _kthToLastNode;
    private readonly DeleteMiddleNode _deleteMiddleNode;

    public LinkedListsTests()
    {
        _deleteSListNode = new DeleteSListNode();
        _removeDuplicates = new RemoveDuplicates();
        _kthToLastNode = new KthToLastNode();
        _deleteMiddleNode = new DeleteMiddleNode();
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

    [TestMethod]
    public void DeleteDuplicates_ApproachITest()
    {
        // Arrange
        SListNode head = new SListNode(1) { 
            Next = new SListNode(2) { 
                Next = new SListNode(2) { 
                    Next = new SListNode(3) { 
                        Next = new SListNode(4) { 
                            Next = new SListNode(4) { 
                                Next = new SListNode(5) 
                            } 
                        } 
                    } 
                } 
            } 
        };

        // Act
        _removeDuplicates.DeleteDups_ApproachI(head);

        // Assert
        Assert.AreEqual(1, head.Value);
        Assert.AreEqual(2, head.Next.Value);
        Assert.AreEqual(3, head.Next.Next.Value);
        Assert.AreEqual(4, head.Next.Next.Next.Value);
        Assert.AreEqual(5, head.Next.Next.Next.Next.Value);
    }

    [TestMethod]
    public void DeleteDuplicates_ApproachIITest()
    {
        // Arrange
        SListNode head = new SListNode(1)
        {
            Next = new SListNode(2)
            {
                Next = new SListNode(2)
                {
                    Next = new SListNode(3)
                    {
                        Next = new SListNode(4)
                        {
                            Next = new SListNode(4)
                            {
                                Next = new SListNode(5)
                            }
                        }
                    }
                }
            }
        };

        // Act
        _removeDuplicates.DeleteDups_ApproachII(head);

        // Assert
        Assert.AreEqual(1, head.Value);
        Assert.AreEqual(2, head.Next.Value);
        Assert.AreEqual(3, head.Next.Next.Value);
        Assert.AreEqual(4, head.Next.Next.Next.Value);
        Assert.AreEqual(5, head.Next.Next.Next.Next.Value);
    }

    [TestMethod]
    public void KthToLast_ApproachITest()
    {
        // Arrange
        SListNode head = new SListNode(1)
        {
            Next = new SListNode(2)
            {
                Next = new SListNode(2)
                {
                    Next = new SListNode(3)
                    {
                        Next = new SListNode(4)
                        {
                            Next = new SListNode(4)
                            {
                                Next = new SListNode(5)
                            }
                        }
                    }
                }
            }
        };

        // Act
        SListNode node  = _kthToLastNode.KthToLast_ApproachI(head, 2);

        // Assert
        Assert.AreEqual(4, node.Value);
    }

    [TestMethod]
    public void KthToLast_ApproachIITest()
    {
        // Arrange
        SListNode head = new SListNode(1)
        {
            Next = new SListNode(2)
            {
                Next = new SListNode(2)
                {
                    Next = new SListNode(3)
                    {
                        Next = new SListNode(4)
                        {
                            Next = new SListNode(4)
                            {
                                Next = new SListNode(5)
                            }
                        }
                    }
                }
            }
        };

        // Act
        SListNode node = _kthToLastNode.KthToLast_ApproachII(head, 2);

        // Assert
        Assert.AreEqual(4, node.Value);
    }

    [TestMethod]
    public void DeleteMiddleNodeTest()
    {
        // Arrange
        SListNode node3 = new SListNode(3)
        {
            Next = new SListNode(4)
            {
                Next = new SListNode(4)
                {
                    Next = new SListNode(5)
                }
            }
        };

        SListNode head = new SListNode(1)
        {
            Next = new SListNode(2)
            {
                Next = new SListNode(2)
                {
                    Next = node3
                }
            }
        };

        // Act
        bool isDeleted = _deleteMiddleNode.DeleteNode(node3);

        // Assert
        Assert.IsTrue(isDeleted);
        Assert.AreEqual(1, head.Value);
        Assert.AreEqual(2, head.Next.Value);
        Assert.AreEqual(2, head.Next.Next.Value);
        Assert.AreEqual(4, head.Next.Next.Next.Value);
        Assert.AreEqual(4, head.Next.Next.Next.Next.Value);
        Assert.AreEqual(5, head.Next.Next.Next.Next.Next.Value);
    }
}