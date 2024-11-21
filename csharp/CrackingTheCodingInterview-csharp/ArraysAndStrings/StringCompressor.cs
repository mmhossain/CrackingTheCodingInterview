using System.Text;

namespace CrackingTheCodingInterview_csharp.ArraysAndStrings;

/*
    1.6 String Compression: Implement a method to perform basic string compression using the counts
        of repeated characters. For example, the string aabcccccaaa would become a2blc5a3. If the
        "compressed" string would not become smaller than the original string, your method should 
        return the original string. You can assume the string has only uppercase and 
        lowercase letters (a - z).
*/
public class StringCompressor
{
    /*
        Time: O(n + k^2)
        Space: O(n)
            n = str.Length
            k = number of unique character sequences
    */
    public string CompressBad_ApproachI(string str)
    {
        string compressed = "";
        int consecutiveCount = 0;

        for (int i = 0; i < str.Length; i++)
        {
            consecutiveCount++;

            if (i + 1 >= str.Length || str[i] != str[i + 1])
            {
                compressed += "" + str[i] + consecutiveCount;   // O(k^2)
                consecutiveCount = 0;
            }
        }

        return compressed.Length < str.Length ? compressed : str;
    }

    /*
        Time: O(n)
        Space: O(n)
            n = str.Length
    */
    public string CompressBad_ApproachII(string str)
    {
        StringBuilder compressed = new StringBuilder();
        int consecutiveCount = 0;

        for (int i = 0; i < str.Length; i++)
        {
            consecutiveCount++;

            if (i + 1 >= str.Length || str[i] != str[i + 1])
            {
                compressed.Append(str[i]);
                compressed.Append(consecutiveCount);
                consecutiveCount = 0;
            }
        }

        return compressed.Length < str.Length ? compressed.ToString() : str;
    }

    /*
        Time: O(n)
        Space: O(n)
            n = str.Length
    */
    public string CompressBad_ApproachIII(string str)
    {
        int compressionLength = getCompressionLength(str);
        if (compressionLength >= str.Length)
            return str;

        StringBuilder compressed = new StringBuilder(compressionLength);
        int consecutiveCount = 0;

        for (int i = 0; i < str.Length; i++)
        {
            consecutiveCount++;

            if (i + 1 >= str.Length || str[i] != str[i + 1])
            {
                compressed.Append(str[i]);
                compressed.Append(consecutiveCount);
                consecutiveCount = 0;
            }
        }

        return compressed.ToString();
    }

    private int getCompressionLength(string str)
    {
        int compressionLength = 0;
        int consecutiveCount = 0;

        for (int i = 0; i < str.Length; i++)
        {
            consecutiveCount++;

            if (i + 1 >= str.Length || str[i] != str[i + 1])
            {
                compressionLength += 1 + ("" + consecutiveCount).Length;
                consecutiveCount = 0;
            }
        }

        return compressionLength;
    }
}
