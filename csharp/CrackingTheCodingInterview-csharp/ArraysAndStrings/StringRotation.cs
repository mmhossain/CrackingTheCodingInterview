namespace CrackingTheCodingInterview_csharp.ArraysAndStrings;

/*
    1.9 String Rotation: Assume you have a method i 5Su b 5 tr ing which checks if one word is a 
        substring of another. Given two strings, 51 and 52, write code to check if 52 is a rotation 
        of 51 using only one call to i5Sub5tring (e.g., "waterbottle" is a rotation of" erbottlewat").
*/
public class StringRotation
{
    /*
        Time: O(n + m)
        Space: O(n + m)
            n = s1.Length
            m = s2.Length
    */
    public bool IsRotation(string s1, string s2)
    {
        if (s1.Length > 0 && s1.Length == s2.Length)
            return isSubstring(s1 + s1, s2);

        return false;
    }

    private bool isSubstring(string s1, string s2)
    {
        return s1.Contains(s2, StringComparison.CurrentCulture);
    }
}
