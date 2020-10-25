using System.Linq;

namespace SudokuKata
{
    public class Kata
    {
        public static string DoneOrNot(int[][] board)
        {
            (int X, int Y) coordinate;

            //line check
            for (int i = 0; i < 9; i++)
            {
                int[] line = new int[9];

                for (int j = 0; j < 9; j++)
                {
                    coordinate = (i, j);
                    line[j] = board[coordinate.X][coordinate.Y];
                }

                if (line.Length != line.Distinct().Count())
                    return "Try again!";
            }

            //column check
            for (int i = 0; i < 9; i++)
            {
                int[] column = new int[9];

                for (int j = 0; j < 9; j++)
                {
                    coordinate = (j, i);
                    column[j] = board[coordinate.X][coordinate.Y];
                }

                if (column.Length != column.Distinct().Count())
                    return "Try again!";
            }

            //region check
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int[] region = new int[9];

                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = 0; l < 3; l++)
                        {
                            coordinate = (l + j * 3, k + i * 3);
                            var t = board[coordinate.X][coordinate.Y];
                            region[l + k * 3] = t;
                        }
                    }

                    if (region.Length != region.Distinct().Count())
                        return "Try again!";
                }
            }

            return "Finished!";
        }
    }
}
