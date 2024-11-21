namespace CrackingTheCodingInterview_csharp.ArraysAnsStrings;

/*
    1.8 Zero Matrix: Write an algorithm such that if an element in an MxN matrix is 0, its entire row 
        and column are set to 0.
*/
public class ZeroMatrix
{
    /*
        Time: O(n x m)
        Space: O(n x m)
            n = number of rows
            m = number of columns
    */
    public void SetZeros_ApproachI(int[][] matrix)
    {
        ISet<int> rows = new HashSet<int>();
        ISet<int> columns = new HashSet<int>();

        for (int r = 0; r < matrix.Length; r++)
        {
            for (int c = 0; c < matrix[r].Length; c++)
            {
                if (matrix[r][c] == 0)
                {
                    rows.Add(r);
                    columns.Add(c);
                }
            }
        }

        for (int r = 0; r < matrix.Length; r++)
        {
            for (int c = 0; c < matrix[r].Length; c++)
            {
                if (rows.Contains(r) || columns.Contains(c))
                    matrix[r][c] = 0;
            }
        }
    }

    /*
        Time: O(n x m)
        Space: O(1)
            n = number of rows
            m = number of columns
    */
    public void SetZeros_ApproachII(int[][] matrix)
    {
        bool isFirstColumnZero = false;

        for (int r = 0; r < matrix.Length; r++)
        {
            if (matrix[r][0] == 0)
                isFirstColumnZero = true;

            for (int c = 1; c < matrix[0].Length; c++)
            {
                if (matrix[r][c] == 0)
                {
                    matrix[r][0] = 0;
                    matrix[0][c] = 0;
                }
            }
        }

        for (int r = 1; r < matrix.Length; r++)
        {
            for (int c = 1; c < matrix[r].Length; c++)
            {
                if (matrix[r][0] == 0 || matrix[0][c] == 0)
                    matrix[r][c] = 0;
            }
        }

        if (matrix[0][0] == 0)
        {
            for (int c = 1; c < matrix[0].Length; c++)
                matrix[0][c] = 0;
        }

        if (isFirstColumnZero)
        {
            for (int r = 1; r < matrix[0].Length; r++)
                matrix[r][0] = 0;
        }
    }
}
