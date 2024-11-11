namespace CrackingTheCodingInterview_csharp.ArraysAnsStrings;

/*
    1.4 Palindrome Permutation: Given a string, write a function to check if it is a permutation of
        a palindrome. A palindrome is a word or phrase that is the same forwards and backwards. 
        A permutation is a rearrangement of letters. The palindrome does not need to be limited to 
        just dictionary words.
*/
public class PalindromePermutation
{
    /*
        Time: O(n)
        Space: O(n)
            n = phrase.Length
    */
    public bool IsPermutationOfPalindrome_ApproachI(string phrase)
    {
        Dictionary<char, int> charCounts = [];

        foreach (char ch in phrase.ToLower())
        {
            if (char.IsLetterOrDigit(ch))
                charCounts[ch] = charCounts.GetValueOrDefault(ch) + 1;
        }

        bool oddFound = false;

        foreach ((char ch, int count) in charCounts)
        {
            if (count % 2 == 1)
            {
                if (oddFound)
                    return false;

                oddFound = true;
            }
        }

        return true;
    }

    /*
        Time: O(n)
        Space: O(n)
            n = phrase.Length
    */
    public bool IsPermutationOfPalindrome_ApproachII(string phrase)
    {
        Dictionary<char, int> charCounts = [];
        int oddCount = 0;

        foreach (char ch in phrase.ToLower())
        {
            if (char.IsLetterOrDigit(ch))
            {
                charCounts[ch] = charCounts.GetValueOrDefault(ch) + 1;

                if (charCounts[ch] % 2 == 1)
                    oddCount++;
                else
                    oddCount--;
            }
        }

        return oddCount <= 1;
    }

    /*
        Time: O(n)
        Space: O(n)
            n = phrase.Length
    */
    public bool IsPermutationOfPalindrome_ApproachIII(string phrase)
    {
        phrase = new string(phrase.ToLower().Where(char.IsLetter).ToArray());
        int bitVector = createBitVector(phrase);
        return bitVector == 0 || checkExactlyOneBitSet(bitVector);
    }

    private int createBitVector(string phrase)
    {
        int bitVector = 0;

        foreach (char ch in phrase)
        {
            int indx = ch - 'a';
            bitVector = toggleBit(bitVector, indx);
        }

        return bitVector;
    }

    private int toggleBit(int bitVector, int indx)
    {
        if (indx < 0)
            return bitVector;

        int mask = 1 << indx;

        if ((bitVector & mask) == 0)
            bitVector |= mask;
        else
            bitVector &= ~mask;

        return bitVector;
    }

    private bool checkExactlyOneBitSet(int bitVector)
        => (bitVector & (bitVector - 1)) == 0;
}
