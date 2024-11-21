namespace CrackingTheCodingInterview_csharp.ArraysAndStrings;

/*
    1.5 One Away: There are three types of edits that can be performed on strings: insert a character,
        remove a character, or replace a character. Given two strings, write a function to check if 
        they are one edit (or zero edits) away.
*/
public class OneAway
{
    /*
        Time: O(n)
        Space: O(1)
            n = Length of the shorter string
    */
    public bool IsOneEditAway_ApproachI(string first, string second)
    {
        if (first.Length == second.Length)
            return isOneEditReplace(first, second);
        
        if (first.Length + 1 == second.Length)
            return isOneEditInsert(first, second);

        if (first.Length - 1 == second.Length)
            return isOneEditInsert(second, first);

        return false;
    }

    private bool isOneEditReplace(string first, string second)
    {
        bool foundDifference = false;

        for (int i = 0; i < first.Length; i++)
        {
            if (first[i] != second[i])
            {
                if (foundDifference)
                    return false;

                foundDifference = true;
            }
        }

        return true;
    }

    private bool isOneEditInsert(string first, string second)
    {
        int indx1 = 0, indx2 = 0;

        while (indx1 < first.Length && indx2 < second.Length)
        {
            if (first[indx1] != second[indx2])
            {
                if (indx1 != indx2)
                    return false;

                indx2++;
            }
            else
            {
                indx1++;
                indx2++;
            }
        }

        return true;
    }

    /*
        Time: O(n)
        Space: O(1)
            n = Length of the shorter string
    */
    public bool IsOneEditAway_ApproachII(string first, string second)
    {
        if (Math.Abs(first.Length - second.Length) > 1)
            return false;

        string shorter = first.Length < second.Length ? first : second;
        string longer = first.Length > second.Length ? first : second;

        int indx1 = 0, indx2 = 0;
        bool foundDifference = false;

        while (indx1 < shorter.Length && indx2 < longer.Length)
        {
            if (shorter[indx1] != longer[indx2])
            {
                if (foundDifference)
                    return false;

                foundDifference = true;

                if (shorter.Length == longer.Length)
                    indx1++;
            }
            else
            {
                indx1++;
            }

            indx2++;
        }

        return true;
    }
}
