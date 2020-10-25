using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace SudokuKata
{
    public class Kata
    {
        public static string DoneOrNot(int[][] board)
        {
            var boardInOneLine = board.SelectMany(x => x).ToArray();

            var result = Enumerable.Range(0, 9).Select(x => boardInOneLine[x * 9]);
            //line check

            //column check

            //region check

            return "Finished!";
        }

    }
}
