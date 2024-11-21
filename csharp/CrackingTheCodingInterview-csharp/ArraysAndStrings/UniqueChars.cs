namespace CrackingTheCodingInterview_csharp.ArraysAndStrings;

/*
    1.1 Is Unique: Implement an algorithm to determine if a string has all unique characters. 
        What if you cannot use additional data structures?
*/
public class UniqueChars
{
    /*
        Time: O(1), since the loop will never go beyond 128
        Space: O(1)
    */
    public bool IsUniqueChars_ApproachI(string str)
    {
        const int CHARSET_LENGTH = 128; // assumption characters are only ASCII

        if (str.Length > CHARSET_LENGTH)
            return false;

        bool[] seen = new bool[CHARSET_LENGTH];

        for (int i = 0; i < str.Length; i++)    // O(128) = O(1)
        {
            if (seen[str[i]])
                return false;

            seen[str[i]] = true;
        }

        return true;
    }

    /*
        Time: O(1), since the loop will never go beyond 26
        Space: O(1)
    */
    public bool IsUniqueChars_ApproachII(string str)
    {
        int checker = 0;

        for (int i = 0; i < str.Length; i++)    // O(26) = O(1)
        {
            int val = str[i] - 'a';

            if ((checker & (1 << val)) > 0)
                return false;

            checker |= (1 << val);
        }

        return true;
    }

    /*
        Time: O(n^2)
        Space: O(1)
    */
    public bool IsUniqueChars_ApproachIII(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = i + 1; j < str.Length; j++)
            {
                if (str[i] == str[j])
                    return false;
            }
        }

        return true;
    }
}
