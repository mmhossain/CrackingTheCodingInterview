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
    private StringCompressor _stringCompressor;
    private MatrixRotator _matrixRotator;

    public ArraysAnsStringsTests()
    {
        _uniqueCharsChecker = new UniqueChars();    
        _permutationChecker = new PermutationChecker();
        _urlify = new Urlify();
        _palindromePermutation = new PalindromePermutation();
        _oneAway = new OneAway();
        _stringCompressor = new StringCompressor();
        _matrixRotator = new MatrixRotator();
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

    [TestMethod]
    public void CompressBad_ApproachITest()
    {
        // Arrange
        string str = "aabcccccaaa";

        // Act
        string compressedString = _stringCompressor.CompressBad_ApproachI(str);

        // Assert
        Assert.AreEqual("a2b1c5a3", compressedString);
    }

    [TestMethod]
    public void CompressBad_ApproachIITest()
    {
        // Arrange
        string str = "aabcccccaaa";

        // Act
        string compressedString = _stringCompressor.CompressBad_ApproachII(str);

        // Assert
        Assert.AreEqual("a2b1c5a3", compressedString);
    }

    [TestMethod]
    public void CompressBad_ApproachIIITest()
    {
        // Arrange
        string str = "aabcccccaaa";

        // Act
        string compressedString = _stringCompressor.CompressBad_ApproachIII(str);

        // Assert
        Assert.AreEqual("a2b1c5a3", compressedString);
    }

    [TestMethod]
    public void RotateMatrixITest()
    {
        // Arrange
        int[][] matrix = [
            [1, 2, 3, 4],
            [5, 6, 7, 8],
            [9, 10, 11, 12],
            [13, 14, 15, 16]
        ];

        // Act
        bool result = _matrixRotator.Rotate_ApproachI(matrix);

        // Assert
        Assert.IsTrue(result);
        Assert.AreEqual("13,9,5,1", string.Join(",", matrix[0]));
        Assert.AreEqual("14,10,6,2", string.Join(",", matrix[1]));
        Assert.AreEqual("15,11,7,3", string.Join(",", matrix[2]));
        Assert.AreEqual("16,12,8,4", string.Join(",", matrix[3]));
    }

    [TestMethod]
    public void RotateMatrixIITest()
    {
        // Arrange
        int[][] matrix = [
            [1, 2, 3, 4],
            [5, 6, 7, 8],
            [9, 10, 11, 12],
            [13, 14, 15, 16]
        ];

        // Act
        bool result = _matrixRotator.Rotate_ApproachII(matrix);

        // Assert
        Assert.IsTrue(result);
        Assert.AreEqual("13,9,5,1", string.Join(",", matrix[0]));
        Assert.AreEqual("14,10,6,2", string.Join(",", matrix[1]));
        Assert.AreEqual("15,11,7,3", string.Join(",", matrix[2]));
        Assert.AreEqual("16,12,8,4", string.Join(",", matrix[3]));
    }
}