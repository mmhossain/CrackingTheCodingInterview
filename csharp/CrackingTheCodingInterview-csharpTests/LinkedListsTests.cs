using CrackingTheCodingInterview_csharp.LinkedLists;

namespace CrackingTheCodingInterview_csharpTests;

[TestClass]
public class LinkedListsTests
{
    private readonly DeleteSListNode _deleteSListNode;
    private readonly RemoveDuplicates _removeDuplicates;

    public LinkedListsTests()
    {
        _deleteSListNode = new DeleteSListNode();
        _removeDuplicates = new RemoveDuplicates();
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
}