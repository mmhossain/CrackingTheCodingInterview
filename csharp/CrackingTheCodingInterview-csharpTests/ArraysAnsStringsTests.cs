using CrackingTheCodingInterview_csharp.ArraysAnsStrings;

namespace CrackingTheCodingInterview_csharpTests;

[TestClass]
public class ArraysAnsStringsTests
{
    private UniqueChars _uniqueCharsChecker;
    private PermutationChecker _permutationChecker;
    private Urlify _urlify;
    private PalindromePermutation _palindromePermutation;
    private OneAway _oneAway;

    public ArraysAnsStringsTests()
    {
        _uniqueCharsChecker = new UniqueChars();    
        _permutationChecker = new PermutationChecker();
        _urlify = new Urlify();
        _palindromePermutation = new PalindromePermutation();
        _oneAway = new OneAway();
    }

    [TestMethod]
    public void IsUniqueChars_ApproachITest()
    {
        // Arrange
        string str = "abcdghik";

        // Act
        bool isUnique = _uniqueCharsChecker.IsUniqueChars_ApproachI(str);

        // Assert
        Assert.IsTrue(isUnique);
    }

    [TestMethod]
    public void IsUniqueChars_ApproachIITest()
    {
        // Arrange
        string str = "abcdghik";

        // Act
        bool isUnique = _uniqueCharsChecker.IsUniqueChars_ApproachII(str);

        // Assert
        Assert.IsTrue(isUnique);
    }

    [TestMethod]
    public void IsUniqueChars_ApproachIIITest()
    {
        // Arrange
        string str = "abcdghik";

        // Act
        bool isUnique = _uniqueCharsChecker.IsUniqueChars_ApproachIII(str);

        // Assert
        Assert.IsTrue(isUnique);
    }

    [TestMethod]
    public void ArePermutations_ApproachITest()
    {
        // Arrange
        string s = "abcdghik", t = "ghcdabik";

        // Act
        bool arePermutations = _permutationChecker.ArePermutations_ApproachI(s, t);

        // Assert
        Assert.IsTrue(arePermutations);
    }

    [TestMethod]
    public void ArePermutations_ApproachIITest()
    {
        // Arrange
        string s = "abcdghik", t = "ghcdabik";

        // Act
        bool arePermutations = _permutationChecker.ArePermutations_ApproachII(s, t);

        // Assert
        Assert.IsTrue(arePermutations);
    }

    [TestMethod]
    public void ReplaceSpaces_ApproachITest()
    {
        // Arrange
        char[] str = ['M', 'r', ' ', 'J', 'o', 'h', 'n', ' ', 'S', 'm', 'i', 't', 'h', ' ', ' ', ' ', ' '];
        int trueLength = 13;

        // Act
        _urlify.ReplaceSpaces_ApproachI(str, trueLength);

        // Assert
        Assert.AreEqual("Mr%20John%20Smith", string.Join("", str));
    }

    [TestMethod]
    public void IsPermutationOfPalindrome_ApproachITest()
    {
        // Arrange
        string phrase = "Tact Coa";

        // Act
        bool isPalindomePermutation = _palindromePermutation.IsPermutationOfPalindrome_ApproachI(phrase);

        // Assert
        Assert.IsTrue(isPalindomePermutation);
    }

    [TestMethod]
    public void IsPermutationOfPalindrome_ApproachIITest()
    {
        // Arrange
        string phrase = "Tact Coa";

        // Act
        bool isPalindomePermutation = _palindromePermutation.IsPermutationOfPalindrome_ApproachII(phrase);

        // Assert
        Assert.IsTrue(isPalindomePermutation);
    }

    [TestMethod]
    public void IsPermutationOfPalindrome_ApproachIIITest()
    {
        // Arrange
        string phrase = "Tact Coa";

        // Act
        bool isPalindomePermutation = _palindromePermutation.IsPermutationOfPalindrome_ApproachIII(phrase);

        // Assert
        Assert.IsTrue(isPalindomePermutation);
    }

    [TestMethod]
    public void IsOneEditAway_ApproachITest()
    {
        // Arrange
        string first = "apple", second = "aple";

        // Act
        bool isOneEditAway = _oneAway.IsOneEditAway_ApproachI(first, second);

        // Assert
        Assert.IsTrue(isOneEditAway);
    }

    [TestMethod]
    public void IsOneEditAway_ApproachIITest()
    {
        // Arrange
        string first = "apple", second = "aple";

        // Act
        bool isOneEditAway = _oneAway.IsOneEditAway_ApproachII(first, second);

        // Assert
        Assert.IsTrue(isOneEditAway);
    }
}