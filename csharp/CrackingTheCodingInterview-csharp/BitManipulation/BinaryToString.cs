using System.Text;

namespace CrackingTheCodingInterview_csharp.BitManipulation;

/*
    5.2 Binary to String: Given a real number between 0 and 1 (e.g., 0.72) that is passed in as a 
        double, print the binary representation. If the number cannot be represented accurately in 
        binary with at most 32 characters, print"ERROR:'
*/
public class BinaryToString
{
    /*
        Time: O(1)
        Space: O(1)
    */
    public string PrintBinary_ApproachI(double num)
    {
        if (num >= 1 || num <= 0)
            return "ERROR";

        StringBuilder binary = new StringBuilder();
        binary.Append(".");

        while (num > 0)
        {
            if (binary.Length >= 32)
                return "ERROR";

            double r = num * 2;
            if (r >= 1)
            {
                binary.Append("1");
                num = r - 1;
            }
            else
            {
                binary.Append("0");
                num = r;
            }
        }

        return binary.ToString();
    }

    /*
        Time: O(1)
        Space: O(1)
    */
    public string PrintBinary_ApproachII(double num)
    {
        if (num >= 1 || num <= 0)
            return "ERROR";

        StringBuilder binary = new StringBuilder();
        binary.Append(".");

        double fraction = 0.5;

        while (num > 0)
        {
            if (binary.Length >= 32)
                return "ERROR";

            if (num >= fraction)
            {
                binary.Append("1");
                num -= fraction;
            }
            else
            {
                binary.Append("0");
            }

            fraction /= 2;
        }

        return binary.ToString();
    }
}