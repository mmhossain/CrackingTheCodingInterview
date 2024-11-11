namespace CrackingTheCodingInterview_csharp.ArraysAnsStrings;

/*
    1.2 Check Permutation: Given two strings, write a method to decide if one is a permutation of 
        the other.
*/
public class PermutationChecker
{
    /*
        Time: O(n log n) + O(m log m) + O(n + m)
        Space: O(n + m)
            n = s.Length
            m = t.Length
    */
    public bool ArePermutations_ApproachI(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        return sort(s).Equals(sort(t));
    }

    private string sort(string s)
    {
        char[] chars = s.ToCharArray();
        Array.Sort(chars);
        return new string(chars);
    }

    /*
        Time: O(n + m)
        Space: O(n + m)
            n = s.Length
            m = t.Length
    */
    public bool ArePermutations_ApproachII(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        const int CHARSET_LENGTH = 128; // assumption characters are only ASCII
        int[] letters = new int[CHARSET_LENGTH];

        foreach (char ch in s)
            letters[ch]++;

        foreach (char ch in t)
        {
            letters[ch]--;
            if (letters[ch] < 0)
                return false;
        }

        return true;
    }
}
