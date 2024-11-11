namespace CrackingTheCodingInterview_csharp.ArraysAnsStrings;

/*
    1.3 URLify: Write a method to replace all spaces in a string with '%20'. You may assume that the 
        string has sufficient space at the end to hold the additional characters, and that you are 
        given the "true" length of the string. (Note: if implementing in Java, please use a character 
        array so that you can perform this operation in place.)
*/
public class Urlify
{
    /*
        Time: O(n)
        Space: O(1)
            n = str.Length
    */
    public void ReplaceSpaces_ApproachI(char[] str, int trueLength)
    {
        int spaceCount = 0;

        for (int i = 0; i < trueLength; i++)
        {
            if (str[i] == ' ')
                spaceCount++;
        }

        int indx = trueLength + spaceCount * 2;

        for (int i = trueLength - 1; i >= 0; i--)
        {
            if (str[i] == ' ')
            {
                str[indx - 1] = '0';
                str[indx - 2] = '2';
                str[indx - 3] = '%';
                indx -= 3;
            }
            else
            {
                str[indx - 1] = str[i];
                indx--;
            }
        }
    }
}
