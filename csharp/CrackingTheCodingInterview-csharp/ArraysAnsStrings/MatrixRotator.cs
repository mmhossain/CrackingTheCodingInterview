namespace CrackingTheCodingInterview_csharp.ArraysAnsStrings;

/*
    1.7 Rotate Matrix: Given an image represented by an NxN matrix, where each pixel in the image is 
        4 bytes, write a method to rotate the image by 90 degrees. Can you do this in place?
*/
public class MatrixRotator
{
    /*
        Time: O(n^2)
        Space: O(1)
            n = matrix.Length
    */
    public bool Rotate_ApproachI(int[][] matrix)
    {
        if (matrix.Length == 0 || matrix.Length != matrix[0].Length) return false;

        int n = matrix.Length;

        for (int layer = 0; layer < n / 2; layer++)
        {
            int first = layer;
            int last = n - 1 - layer;

            for (int i = first; i < last; i++)
            {
                int offset = i - first;

                // save top
                int top = matrix[first][i];

                // left -> top
                matrix[first][i] = matrix[last - offset][first];

                // bottom -> left
                matrix[last - offset][first] = matrix[last][last - offset];

                // right -> bottom
                matrix[last][last - offset] = matrix[i][last];

                // top -> right
                matrix[i][last] = top;
            }
        }

        return true;
    }

    /*
        Time: O(n^2)
        Space: O(1)
            n = matrix.Length
    */
    public bool Rotate_ApproachII(int[][] matrix)
    {
        if (matrix.Length == 0 || matrix.Length != matrix[0].Length) return false;

        transpose(matrix);
        reverse(matrix);

        return true;
    }

    private void transpose(int[][] matrix)
    {
        for (int r = 0; r < matrix.Length; r++)
        {
            for (int c = r; c < matrix[r].Length; c++)
            {
                int temp = matrix[r][c];
                matrix[r][c] = matrix[c][r];
                matrix[c][r] = temp;
            }
        }
    }

    private void reverse(int[][] matrix)
    {
        for (int r = 0; r < matrix.Length; r++)
        {
            int n = matrix[r].Length;
            for (int c = 0; c < n / 2; c++)
            {
                int temp = matrix[r][c];
                matrix[r][c] = matrix[r][n - c - 1];
                matrix[r][n - c - 1] = temp;
            }
        }
    }
}
