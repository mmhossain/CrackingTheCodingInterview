namespace CrackingTheCodingInterview_csharp.BitManipulation;

/*
    5.1 Insertion: You are given two 32-bit numbers, N and M, and two bit positions, i and j. 
        Write a method to insert Minto N such that M starts at bit j and ends at bit i. You can 
        assume that the bits j through i have enough space to fit all of M. That is, if M = 10011, 
        you can assume that there are at least 5 bits between j and i. You would not, for example, 
        have j = 3 and i = 2, because M could not fully fit between bit 3 and bit 2.
*/
public class Insertion
{
    /*
        Time: O(1)
        Space: O(1)
    */
    public int UpdateBits(int n, int m, int i, int j)
    {
        int allOnes = ~0;   // sequence of 1s
        int left = allOnes << (j + 1);  // clear the right bits
        int right = (1 << i) - 1;   // clear the left bits
        int mask = left | right;    // all 0s between i and j

        int nCleared = n & mask;    // all bits are cleared between i and j
        int mShifted = m << i;      // position m to the correct place

        return nCleared | mShifted; // now merge
    }
}