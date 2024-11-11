namespace CrackingTheCodingInterview_csharp.ArraysAnsStrings.Tests;

[TestClass]
public class IsUniqueTests
{
    [TestMethod]
    public void IsUniqueChars_ApproachITest()
    {
        // Arrange
        var isUnique = new IsUnique();
        string str = "abcdghik";

        // Act
        bool result = isUnique.IsUniqueChars_ApproachI(str);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsUniqueChars_ApproachIITest()
    {
        // Arrange
        var isUnique = new IsUnique();
        string str = "abcdghik";

        // Act
        bool result = isUnique.IsUniqueChars_ApproachII(str);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsUniqueChars_ApproachIIITest()
    {
        // Arrange
        var isUnique = new IsUnique();
        string str = "abcdghik";

        // Act
        bool result = isUnique.IsUniqueChars_ApproachIII(str);

        // Assert
        Assert.IsTrue(result);
    }
}