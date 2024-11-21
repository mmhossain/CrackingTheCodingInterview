using CrackingTheCodingInterview_csharp.LinkedLists;

namespace CrackingTheCodingInterview_csharpTests;

[TestClass]
public class LinkedListsTests
{
    private readonly DeleteSListNode _deleteSListNode;
    private readonly RemoveDuplicates _removeDuplicates;
    private readonly KthToLastNode _kthToLastNode;
    private readonly DeleteMiddleNode _deleteMiddleNode;
    private readonly PartitionList _partitionList;
    private readonly SumLists _sumLists;

    public LinkedListsTests()
    {
        _deleteSListNode = new DeleteSListNode();
        _removeDuplicates = new RemoveDuplicates();
        _kthToLastNode = new KthToLastNode();
        _deleteMiddleNode = new DeleteMiddleNode();
        _partitionList = new PartitionList();
        _sumLists = new SumLists();
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

    [TestMethod]
    public void Partition_ApproachITest()
    {
        // Arrange
        SListNode head = new SListNode(3)
        {
            Next = new SListNode(5)
            {
                Next = new SListNode(8)
                {
                    Next = new SListNode(5)
                    {
                        Next = new SListNode(10)
                        {
                            Next = new SListNode(2)
                            {
                                Next = new SListNode(1)
                            }
                        }
                    }
                }
            }
        };

        // Act
        SListNode updatedHead = _partitionList.Partition_ApproachI(head, 5);

        // Assert
        Assert.AreEqual(3, updatedHead.Value);
        Assert.AreEqual(2, updatedHead.Next.Value);
        Assert.AreEqual(1, updatedHead.Next.Next.Value);
        Assert.AreEqual(5, updatedHead.Next.Next.Next.Value);
        Assert.AreEqual(8, updatedHead.Next.Next.Next.Next.Value);
        Assert.AreEqual(5, updatedHead.Next.Next.Next.Next.Next.Value);
        Assert.AreEqual(10, updatedHead.Next.Next.Next.Next.Next.Next.Value);
    }

    [TestMethod]
    public void Partition_ApproachIITest()
    {
        // Arrange
        SListNode head = new SListNode(3)
        {
            Next = new SListNode(5)
            {
                Next = new SListNode(8)
                {
                    Next = new SListNode(5)
                    {
                        Next = new SListNode(10)
                        {
                            Next = new SListNode(2)
                            {
                                Next = new SListNode(1)
                            }
                        }
                    }
                }
            }
        };

        // Act
        SListNode updatedHead = _partitionList.Partition_ApproachII(head, 5);

        // Assert
        Assert.AreEqual(1, updatedHead.Value);
        Assert.AreEqual(2, updatedHead.Next.Value);
        Assert.AreEqual(3, updatedHead.Next.Next.Value);
        Assert.AreEqual(5, updatedHead.Next.Next.Next.Value);
        Assert.AreEqual(8, updatedHead.Next.Next.Next.Next.Value);
        Assert.AreEqual(5, updatedHead.Next.Next.Next.Next.Next.Value);
        Assert.AreEqual(10, updatedHead.Next.Next.Next.Next.Next.Next.Value);
    }

    [TestMethod]
    public void SumLists_ApproachITest()
    {
        // Arrange
        SListNode l1 = new SListNode(7)
        {
            Next = new SListNode(1)
            {
                Next = new SListNode(6)
            }
        };

        SListNode l2 = new SListNode(5)
        {
            Next = new SListNode(9)
            {
                Next = new SListNode(2)
            }
        };

        // Act
        SListNode result = _sumLists.AddLists_ApproachI(l1, l2, 0);

        // Assert
        Assert.AreEqual(2, result.Value);
        Assert.AreEqual(1, result.Next.Value);
        Assert.AreEqual(9, result.Next.Next.Value);
    }

    [TestMethod]
    public void SumLists_ApproachIITest()
    {
        // Arrange
        SListNode l1 = new SListNode(6)
        {
            Next = new SListNode(1)
            {
                Next = new SListNode(7)
            }
        };

        SListNode l2 = new SListNode(2)
        {
            Next = new SListNode(9)
            {
                Next = new SListNode(5)
            }
        };

        // Act
        SListNode result = _sumLists.AddLists_ApproachII(l1, l2);

        // Assert
        Assert.AreEqual(9, result.Value);
        Assert.AreEqual(1, result.Next.Value);
        Assert.AreEqual(2, result.Next.Next.Value);
    }
}