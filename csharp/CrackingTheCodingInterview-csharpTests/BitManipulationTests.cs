using CrackingTheCodingInterview_csharp.BitManipulation;

namespace CrackingTheCodingInterview_csharpTests;

[TestClass]
public class BitManipulationTests
{
    private readonly Insertion _insertion;
    private readonly BinaryToString _binaryToString;

    public BitManipulationTests()
    {
        _insertion = new Insertion();
        _binaryToString = new BinaryToString();
    }

    [TestMethod]
    public void UpdateBitsTest()
    {
        // Arrange
        int n = 0b10000000000, m = 0b10011, i = 2, j = 6;

        // Act
        int result = _insertion.UpdateBits(n, m, i, j);

        // Assert
        Assert.AreEqual(0b10001001100, result);
    }

    [TestMethod]
    public void PrintBinary_ApproachITest()
    {
        // Arrange
        double num = 0.25;

        // Act
        string result = _binaryToString.PrintBinary_ApproachI(num);

        // Assert
        Assert.AreEqual(".01", result);
    }

    [TestMethod]
    public void PrintBinary_ApproachIITest()
    {
        // Arrange
        double num = 0.25;

        // Act
        string result = _binaryToString.PrintBinary_ApproachII(num);

        // Assert
        Assert.AreEqual(".01", result);
    }
}