using CrackingTheCodingInterview_csharp.BitManipulation;

namespace CrackingTheCodingInterview_csharpTests;

[TestClass]
public class BitManipulationTests
{
    private readonly Insertion _insertion;

    public BitManipulationTests()
    {
        _insertion = new Insertion();
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
}